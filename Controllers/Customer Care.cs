using Microsoft.AspNetCore.Mvc;

namespace FisherInsurance.Controllers
{

   
  [Route("claim")]
 
public class CustomerCareController : Controller
{
      [Route("index")]

    public IActionResult Index()
        {
            return Ok("This is the index of the Customer Care Controller");
        }
      [Route("claim")]

    public IActionResult Quote() 
        {
            return Ok("This is the Customer Care quote"); 
        }
    
  
    
    [Route("fileclaims")]
    public IActionResult NewClaim()
    {
            return Ok("This is the new claims");
    }
    [Route("myclaims")]
    public IActionResult ClaimHistory()
    {
            return Ok("This is the Claim History");
    }
  }
}