using CadastroSeries.Models;
using GerenciadorDespesas.Mapeamento;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Threading.Tasks;

namespace GerenciadorDespesas.Models
{
    public class Contexto : DbContext
    {

        public DbSet<Serie> Series { get; set; }
        public DbSet<Genero> Generos { get; set; }
        public Contexto(DbContextOptions<Contexto> opcoes) : base(opcoes) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Serie>().HasOne(s=> s.Genero).WithMany(s => s.Series).HasForeignKey(s => s.GeneroId);

            modelBuilder.Entity<Genero>().HasMany(g => g.Series).WithOne(g => g.Genero);
        }

    }
}