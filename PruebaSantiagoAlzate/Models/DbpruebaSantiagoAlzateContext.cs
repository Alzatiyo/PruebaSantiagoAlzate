using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace PruebaSantiagoAlzate.Models;

public partial class DbpruebaSantiagoAlzateContext : DbContext
{
    public DbpruebaSantiagoAlzateContext()
    {
    }

    public DbpruebaSantiagoAlzateContext(DbContextOptions<DbpruebaSantiagoAlzateContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Producto> Productos { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (!optionsBuilder.IsConfigured)
        {

        }
    }
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
//        => optionsBuilder.UseSqlServer("Server=DESKTOP-ATOMHDM;Database=DBPruebaSantiagoAlzate;Encrypt=False;User Id=tecnoware;Password=M5rc13.l4g0!;integrated security=False;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Producto>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Producto__3214EC0789CB0E15");

            entity.Property(e => e.Nombre).HasMaxLength(50);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
