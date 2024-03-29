﻿using System.Configuration.Provider;
using Microsoft.EntityFrameworkCore;
using PlanckEnergyMVC.Models;

namespace PlanckEnergyMVC.DAL;

public class MaterialDbContext : DbContext
{
    public DbSet<Material> Materials { get; set; }

    protected readonly IConfiguration Configuration;

    public MaterialDbContext(DbContextOptions<MaterialDbContext> options) : base(options) { }

    //protected override void OnConfiguring(DbContextOptionsBuilder options)
    //{
    //    options.UseSqlServer(Configuration.GetConnectionString("planckDB"));
    //}
}
