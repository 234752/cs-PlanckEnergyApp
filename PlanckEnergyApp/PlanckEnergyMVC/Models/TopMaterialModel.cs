﻿using HtmlAgilityPack;
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
    private string _ingredientsLink;
    public string IngredientsLink
    {
        get { return _ingredientsLink; }
        set { _ingredientsLink = value;}
    }
    private string _manufacturingLink;
    public string ManufacturingLink
    {
        get { return _manufacturingLink; }
        set { _manufacturingLink = value; }
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
        _ingredientsLink = url;

    }

    public async Task MineManufacturing()
    {
        var url = "https://www.sciencedirect.com/science/article/abs/pii/S138358662100188X";

        var web = new HtmlWeb();
        var doc = web.Load(url);

        var paragraphs = doc.DocumentNode.SelectNodes("//p");

        var manufacturingParagraph = paragraphs.Where(p => p.InnerText.Contains("UiO-66 was fabricated")).ToList().First();

        _minedManufacturing = manufacturingParagraph.InnerText;
        _manufacturingLink = url;

    }
}
