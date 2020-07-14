using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MovieStore.MVC.Models;

namespace MovieStore.MVC.Controllers
{
    //any c# class can become a MVC Controller if it inherits from Controller class Microsoft.AspNetCore.Mvc
    //GET http://localhost:2323/home/index, home is controller, index is action method
    //Routing-- Pattern matching technique, look into the url
    //HomeControlller
    //Index--Action method
    public class HomeController : Controller
    {
        //Action method
        public IActionResult Index()
        {
            //return an instance of a class that implements that IActonResult
            //By default, MVC will look for same View name as Action method name
            //It will look inside Views folder-->Home(same name as Controller)-->Index.cshtml
            //Steps:
            //1.Program.cs--Main method;
            //2.Startup Class
            //3.ConfigureServices
            //4.Configure
            //5.HomeController
            //6.Actionmethod
            //7.return a View
            //In Asp.Net Core Middleware.....a piece of software logic that will be executed
            //Train starting from DC to Boston,DC, 20 ppl on train, multiple stops..NJ, NY--Boston
            //Middleware is like these stops that HTTP request has to go through before receiving the response
            //request-->m1--some process--next m2--next m3..m5.-->response
            //every middleware has to make sure call the next middleware and works well
            //order of middlewares is really important, if you change the order, it won't work well
            return View();
        }

        
    }

    public interface XYX
    {
        int Add(int x, int y);
    }
    public interface ABC
    {
        int Add(int x, int y);

    }
    public class MyClass: XYX, ABC
    {
        public int Add(int x, int y)
        {
            return x+y;
        }
        public int ABC(int x, int y)
        {
            return x + y;
        }
    }
}

