using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Estacionamento.Models
{
    public class Contexto: DbContext
    {
         public Contexto(DbContextOptions<Contexto>options): base(options){

        }

        public DbSet<Cliente> Cliente{get; set;}

        public DbSet<Veiculo> Veiculo{get;set;}

           protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Veiculo>()
            .HasOne(a => a.cliente)
            .WithMany(c => c.Veiculo)
            .HasForeignKey(c => c.clienteId)
            .IsRequired();
    }
}
}