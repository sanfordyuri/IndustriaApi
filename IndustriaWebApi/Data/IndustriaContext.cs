using IndustriaWebApi.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace IndustriaWebApi.Data
{
    public class IndustriaContext : DbContext
    {
        protected readonly IConfiguration Configuration;

        public IndustriaContext(DbContextOptions<IndustriaContext> opts, IConfiguration configuration) : base(opts)
        {
            Configuration = configuration;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            var connectionString = Configuration.GetConnectionString("IndustriaConnection");
            options.UseMySQL(connectionString);
        }

        public DbSet<Produto> Produtos { get; set; }
        public DbSet<MateriaPrima> MateriasPrimas { get; set; }
    }
}
