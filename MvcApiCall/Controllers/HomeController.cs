using Microsoft.AspNetCore.Mvc;
using MvcApiCall.Models;
using System;

namespace MvcApiCall.Controllers
{
  public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var allArticles = Article.GetArticles(EnvironmentVariables.ApiKey);
            
            return View(allArticles);
        }
    }
}
