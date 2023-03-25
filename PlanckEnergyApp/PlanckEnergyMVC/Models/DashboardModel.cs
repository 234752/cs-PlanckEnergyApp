using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PlanckEnergyMVC.DAL;

namespace PlanckEnergyMVC.Models;

public class DashboardModel
{
    private MaterialDbContext _dbContext;
    private List<Material> _topVolumeMaterials= new List<Material>();
    public List<Material> TopVolumeMaterials
    { 
        get { return _topVolumeMaterials; }
        set { _topVolumeMaterials = value; }
    }
    private int _amountOfMaterials;
    public int AmountOfMaterials
    {
        get { return _amountOfMaterials; }
        set { _amountOfMaterials = value; }
    }

    public DashboardModel(MaterialDbContext dbContext) 
    { 
        _dbContext = dbContext;
    }

    public async Task FetchTopVolumeMaterials()
    {
        _topVolumeMaterials = new List<Material>();
        _topVolumeMaterials = await _dbContext.Materials.OrderByDescending(m => Convert.ToDecimal(m._cell_volume)).Take(_amountOfMaterials).ToListAsync();
    }
}
