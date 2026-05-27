using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace ASPNYOLCMASODJARA.Models;

public partial class motorcyclesDBContext : DbContext
{
    public motorcyclesDBContext()
    {
    }

    public motorcyclesDBContext(DbContextOptions<motorcyclesDBContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Motorcycle> Motorcycles { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=motorcyclesDB;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Motorcycle>(entity =>
        {
            entity.HasKey(e => e.MotorcycleId).HasName("PK__Motorcyc__3D94D75345C96799");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
