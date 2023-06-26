using Microsoft.EntityFrameworkCore;
using WebPostgreSQL.Models;

namespace WebPostgreSQL.Context
{
    public class Contexto : DbContext
    {
        public Contexto(DbContextOptions<Contexto> options) : base(options)
        {
            this.Database.EnsureCreated();
        }

        DbSet<Produto> Produtos { get; set; }
    }
}
