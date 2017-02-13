
using Microsoft.AspNetCore.Mvc;
using System;
using FisherInsurance.Models;
namespace FisherInsurance.Controllers
{ 
public class LifeController : Controller
{
            Quote quote =new Quote
    {
        Id=345,
        Product = "Life Insurance",
        ExpireDate = DateTime.Now.AddDays(46),    
        Price =47.00M
    };
    public IActionResult Index() 
    {
      //  return Ok("This is the index of the AutoController"); 
        return View();
    }

    public IActionResult Quote() 
    {
        
       // return Ok("This is the auto quote"); 
               return View(quote);

    }
    
 }
}
