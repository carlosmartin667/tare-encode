﻿using Entidades;
using Microsoft.EntityFrameworkCore;

namespace Infraestructura
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

        }
        public DbSet<CredencialesUsuarioModel> Usuario { get; set; }

        public DbSet<ActividadesUsuarioModel> Actividades { get; set; }

    }
}
