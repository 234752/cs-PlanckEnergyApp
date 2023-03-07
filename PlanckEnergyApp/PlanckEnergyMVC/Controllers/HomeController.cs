using Microsoft.AspNetCore.Mvc;
using PlanckEnergyMVC.Models;
using System.Diagnostics;

namespace PlanckEnergyMVC.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Dashboard()
    {
        //Waiting for the database to be connected.
        List<RowItem1Model> items = new List<RowItem1Model>
        {
            new RowItem1Model("test"),
            new RowItem1Model("test"),
            new RowItem1Model("test"),
            new RowItem1Model("test"),
            new RowItem1Model("test"),
            new RowItem1Model("test"),
            new RowItem1Model("test"),
            new RowItem1Model("test"),
            new RowItem1Model("test"),
            new RowItem1Model("test"),
            new RowItem1Model("test"),
            new RowItem1Model("test"),
            new RowItem1Model("test"),
            new RowItem1Model("test"),
            new RowItem1Model("test"),
            new RowItem1Model("test")
        };
        return View(items);
        //return View();
    }

    public IActionResult Preparation()
    {
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