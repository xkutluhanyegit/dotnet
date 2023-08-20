using System.Diagnostics;
using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Mvc;
using UI.Models;

namespace UI.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    IProductService _productService;

    public HomeController(ILogger<HomeController> logger,IProductService productService)
    {
        _logger = logger;
        _productService = productService;
    }

    public IActionResult Index()
    {
        Products p = new Products();
        p.ProductName = "First";
        p.ProductDescription = "Second";
        _productService.Add(p);
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
