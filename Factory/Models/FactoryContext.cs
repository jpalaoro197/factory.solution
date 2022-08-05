using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
namespace Factory.Models
{
  public class FactoryContext : DbContext
  {
    

    public FactoryContext(DbContextOptions options) : base(options) { }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
      optionsBuilder.UseLazyLoadingProxies();
    }
  }
}