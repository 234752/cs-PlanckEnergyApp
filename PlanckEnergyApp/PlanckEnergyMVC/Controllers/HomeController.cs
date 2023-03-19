using Microsoft.AspNetCore.Mvc;
using PlanckEnergyMVC.DAL;
using PlanckEnergyMVC.Models;
using System.Diagnostics;

namespace PlanckEnergyMVC.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private readonly MaterialDbContext _dbContext;

    public HomeController(ILogger<HomeController> logger, MaterialDbContext context)
    {
        _logger = logger;
        _dbContext = context;
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
            new RowItem1Model("test", "test1", "test2", "test3"),
            new RowItem1Model("test", "test1", "test2", "test3"),
            new RowItem1Model("test", "test1", "test2", "test3"),
            new RowItem1Model("test", "test1", "test2", "test3"),
            new RowItem1Model("test", "test1", "test2", "test3"),
            new RowItem1Model("test", "test1", "test2", "test3"),
            new RowItem1Model("test", "test1", "test2", "test3"),
            new RowItem1Model("test", "test1", "test2", "test3"),
            new RowItem1Model("test", "test1", "test2", "test3"),
            new RowItem1Model("test", "test1", "test2", "test3"),
            new RowItem1Model("test", "test1", "test2", "test3"),
            new RowItem1Model("test", "test1", "test2", "test3")
        };
        return View(items);
        //return View();
    }

    public IActionResult Preparation()
    {
        var mat = _dbContext.Materials.ToList();
        return View(mat.First());
    }

    public IActionResult Sorted()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}