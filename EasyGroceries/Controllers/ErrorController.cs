
using Microsoft.AspNetCore.Mvc;

namespace EasyGroceries.Controllers;
[ApiController]
public class ErrorController : ControllerBase {
    [Route("/error")]
    public IActionResult Error(Guid id) {
       return Problem();
    }
}