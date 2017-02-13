using Microsoft.AspNetCore.Mvc;
using System;
using FisherInsurance.Models;

namespace FisherInsurance.Controllers
{
public class HomesController : Controller
{

         Quote quote =new Quote
    {
        Id=345,
        Product = "Homes Insurance",
        ExpireDate = DateTime.Now.AddDays(46),    
        Price =46.00M
    };
    public IActionResult Index() 
    {
        //return Ok("This is the index of the HomesController"); 
        return View();
    }

  
  public IActionResult Quote() 
    {
        //return Ok("This is the Homes quote"); 
        return View(quote);
    }

    
   }

}