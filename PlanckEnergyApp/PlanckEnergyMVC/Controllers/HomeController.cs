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

    public async Task<IActionResult> Dashboard()
    {
        var dashboardModel = new DashboardModel(_dbContext);
        await dashboardModel.FetchTopVolumeMaterials();
        return View(dashboardModel);
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