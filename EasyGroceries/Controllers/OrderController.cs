
using Microsoft.AspNetCore.Mvc;
using EasyGroceries.Services.Order;
using EasyGrocries.Contracts.Catalog;
using EasyGrocries.Contracts.Order;
using EasyGroceries.Models;

namespace EasyGroceries.Controllers;
[ApiController]
public class OrderController : ControllerBase {
    private readonly IOrderService _orderService;

    public OrderController(IOrderService orderService)
    {
        _orderService = orderService;
    }

    [HttpGet("/order")]
    public IActionResult Get() {


        return Ok( _orderService.GetOrders());
    }

    [HttpGet("/order/{id:guid}")]
    public IActionResult Get(Guid id) {
        var order = _orderService.GetOne(id);
        return Ok(order);
    }


    [HttpPost("/order")]
    public IActionResult Add(Order order) 
    {
        Guid newId = _orderService.AddOrder(
           _orderService.ProcessOrder(order)
        );
        return CreatedAtAction(nameof(Get),order);
    }
}