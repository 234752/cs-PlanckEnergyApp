using HtmlAgilityPack;
using PlanckEnergyMVC.DAL;
using System.Net;
using System.Text;

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

    public TopMaterialModel(MaterialDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public async Task MineIngredients()
    {
        var url = "https://www.sciencedirect.com/science/article/abs/pii/S1385894722063616";

        var web = new HtmlWeb();
        var doc = web.Load(url);

        var paragraphs = doc.DocumentNode.SelectNodes("//p");

        var materialsParagraph = paragraphs.Where(p => p.InnerText.Contains("Zirconium (IV) chloride")).ToList().First();

        _minedIngredients = materialsParagraph.InnerText;

    }
}
