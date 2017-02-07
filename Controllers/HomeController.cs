using Microsoft.AspNetCore.Mvc;
namespace FisherInsurance.Controllers
{
public class HomeController : Controller
{
    public IActionResult Index()
 {
 return Ok("This is the index of the HomeController");
   }
 }
}