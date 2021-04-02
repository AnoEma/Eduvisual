using EduvisualDomain.Models;
using Microsoft.EntityFrameworkCore;

namespace EduvisualWebApp.Context
{
    public class EduvisualContext : DbContext
    {
        public EduvisualContext(DbContextOptions<EduvisualContext> options) : base(options)
        {
        }

        public DbSet<Funcionario> Funcionarios { get; set; }
        public DbSet<Equipamento> Equipamentos { get; set; }
        public DbSet<ReservaEquipamento> ReservaEquipamentos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Funcionario>().HasKey(m => m.IdFuncionario);
            modelBuilder.Entity<Equipamento>().HasKey(m => m.Id);
            modelBuilder.Entity<ReservaEquipamento>().HasKey(m => m.IdReserva);
            base.OnModelCreating(modelBuilder);
        }
    }
}