
using Microsoft.AspNetCore.Mvc;
namespace API.Controllers 
{

[ApiController]
[Route("api/[controller]")]
public class ProductsController : ControllerBase
{
    [HttpGet]
    public string GetProducts() {
        return "đây là hàm get";
    }
      [HttpGet("{id}")]
    public string GetProduct(int id) {
        return "đây là hàm get by id";
    }

}
}