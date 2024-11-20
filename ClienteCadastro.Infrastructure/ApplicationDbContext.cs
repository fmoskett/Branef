using Microsoft.EntityFrameworkCore;
using ClienteCadastro.Domain.Entities;
using System.Collections.Generic;

namespace ClienteCadastro.Infrastructure.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<Cliente> Clientes { get; set; }
    }
}
