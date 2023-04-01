using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PlanckEnergyMVC.DAL;

namespace PlanckEnergyMVC.Models;

public class SearchModel
{
    private MaterialDbContext _dbContext;
    private string _minedText;
    public string MinedText
    { 
        get { return _minedText; } 
        set { _minedText = value; } 
    }

    public SearchModel(MaterialDbContext dbContext)
    { 
        _dbContext = dbContext;
    }
    private async Task<string> SearchWeb(string phrase) //mock method, need to implement the actual text mining here
    {
        return "sample mined text";
    }
    public async Task MineText(string id)
    {
        if(id == "Empty")
        {
            _minedText = "";
            return;
        }
        var requestedMaterial = _dbContext.Materials.Where(m => m.Name == id).SingleOrDefault();
        if(requestedMaterial == null) 
        {
            _minedText = $"there is no information in our database about '{id}'";
            return;
        }
        var webResult = await SearchWeb(id);
        _minedText = $"{webResult} for material '{id}'";
    }

}
