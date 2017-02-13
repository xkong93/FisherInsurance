using Microsoft.AspNetCore.Mvc;
namespace FisherInsurance.Controllers
{ 
public class LifeController : Controller
{
    public IActionResult Index() 
    {
      //  return Ok("This is the index of the AutoController"); 
        return View();
    }

    public IActionResult Quote() 
    {
        
        return Ok("This is the auto quote"); 
    }
    
 }
}
