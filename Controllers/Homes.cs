using Microsoft.AspNetCore.Mvc;

namespace FisherInsurance.Controllers
{
public class HomesController : Controller
{
    public IActionResult Index() 
    {
        return Ok("This is the index of the HomesController"); 
    }

  
  public IActionResult Quote() 
    {
        return Ok("This is the Homes quote"); 
    }

    
   }

}