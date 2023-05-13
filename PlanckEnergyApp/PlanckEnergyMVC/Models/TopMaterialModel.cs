using PlanckEnergyMVC.DAL;

namespace PlanckEnergyMVC.Models;

public class TopMaterialModel
{
    private MaterialDbContext _dbContext;
    private string _minedIngredients;
    public string MinedIngredients
    {
        get { return _minedIngredients; }
        set { _minedIngredients = value; }
    }
    private string _minedManufacturing;
    public string MinedManufacturing
    {
        get { return _minedManufacturing; }
        set { _minedManufacturing = value; }
    }
}
