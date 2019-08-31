using System;
using Microsoft.AspNetCore.Mvc;
using dotnet_web.models;

namespace dotnet_web.Controllers
{

    public class Homecontroller:Controller{


        public IActionResult Index(){
            Console.WriteLine("Index");
            return View();
        }
        
   
        }
    }



