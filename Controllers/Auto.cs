using Microsoft.AspNetCore.Mvc;
using System;
using FisherInsurance.Models;

namespace FisherInsurance.Controllers
{
public class AutoController : Controller
{
    
      
    public IActionResult index() 
    {
        //return Ok("This is the index of the AutoController"); 
        return View();
    }
    
    
    public IActionResult Quote() 
    {
             Quote quote =new Quote
    {
        Id=345,
        Product = "Auto Insurance",
        ExpireDate = DateTime.Now.AddDays(45),    
        Price =45.00M
    };
        return View(quote);
        //return Ok("This is the auto quote"); 
    }
    
   
}
}