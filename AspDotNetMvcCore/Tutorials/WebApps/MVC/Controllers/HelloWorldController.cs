using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Encodings.Web;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace MVC.Controllers
{
    public class HelloWorldController : Controller
    {
        public string Index()
        {
            return "Welcome to the HelloWorld controller";
        }

        public string Welcome(string name, int id = 1)
        {
            return HtmlEncoder.Default.Encode($"{name}, NumTimes is : {id}");
        }
    }
}