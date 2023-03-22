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

    public DashboardModel(MaterialDbContext dbContext) 
    { 
        _dbContext = dbContext;
    }

    internal async Task FetchTopVolumeMaterials()
    {
        _topVolumeMaterials = await _dbContext.Materials.OrderByDescending(m => Convert.ToDecimal(m._cell_volume)).Take(10).ToListAsync();
    }
}
