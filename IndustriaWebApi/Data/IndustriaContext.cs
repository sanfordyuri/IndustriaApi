using IndustriaWebApi.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace IndustriaWebApi.Data
{
    public class IndustriaContext : DbContext
    {
        public IndustriaContext(DbContextOptions<IndustriaContext> opts) : base(opts)
        {

        }
        public DbSet<Produto> Produtos { get; set; }
        public DbSet<MateriaPrima> MateriasPrimas { get; set; }
    }
}
