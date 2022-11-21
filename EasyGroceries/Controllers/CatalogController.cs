
using Microsoft.AspNetCore.Mvc;
using EasyGroceries.Services.Catalog;
using EasyGrocries.Contracts.Catalog;

namespace EasyGroceries.Controllers;
[ApiController]

public class CatalogController : ControllerBase {
    private readonly ICatalogService _catalogService;

    public CatalogController(ICatalogService catalogService)
    {
        _catalogService = catalogService;
    }

    [HttpGet("/catalog")]
    public IActionResult Get() {
        return Ok( _catalogService.GetCatalog());
    }

    [HttpGet("/catalog/{id:guid}")]
    public IActionResult Get(Guid id) {
        var catalog = _catalogService.GetOne(id);
        var response = new CatalogResponse(
            catalog.Name,
            catalog.Description,
            catalog.Quantity,
            catalog.Id,
            catalog.Price,
            catalog.Type
        );
        return Ok(response);
    }


    [HttpPost("/catalog")]
    public IActionResult Add(CreateCatalogRequest request) 
    {
        Guid newId = _catalogService.AddCatalog(new Models.Catalog(
            Guid.NewGuid(), 
            request.Name,
            request.Description,
            request.Quantity, 
            request.Price,
            request.Type
        ));

            var response = new CatalogResponse(
                request.Name,
                request.Description,
                request.Quantity,
                newId,
                request.Price,
                request.Type
            );

            return CreatedAtAction(nameof(Get),response);
    }
}