using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace PlanckEnergyMVC.Models;

public class MaterialDbContext : DbContext
{
    public MaterialDbContext() : base("MaterialDbContext") { }

    public DbSet<Material> Materials { get; set; }
}
