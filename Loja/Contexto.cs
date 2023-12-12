using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Cadastro
{
    public class Contexto : DbContext
    {
        public DbSet<Produto> Produtos { get; set; }
        public DbSet<Fornecedor> Fornecedores { get; set; }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Nota> Notas { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionString = "Server=127.0.0.1;Database=cadastro;User=SA;Password=Sql12345";
            optionsBuilder.UseSqlServer(connectionString);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Aqui você pode configurar o mapeamento entre as classes e as tabelas do banco de dados
            modelBuilder.Entity<Fornecedor>().ToTable("Fornecedores");
            modelBuilder.Entity<Produto>().ToTable("Produtos");
            modelBuilder.Entity<Cliente>().ToTable("Clientes");
            modelBuilder.Entity<Nota>().ToTable("Notas");
        }
    }
}