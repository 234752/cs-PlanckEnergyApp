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
    public async Task MineText(string id)
    {
        if(id == "Empty")
        {
            _minedText = "";
            return;
        }
        _minedText = $"sample mined text for material '{id}'";
    }

}
