using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace DBfirstapp.Models;

public partial class RanuDbContext : DbContext
{
    public RanuDbContext()
    {
    }

    public RanuDbContext(DbContextOptions<RanuDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Cook> Cooks { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("User ID=sa;password=examlyMssql@123;server=localhost;Database=RanuDb;trusted_connection=false;Persist Security Info=false;Encrypt=false");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Cook>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.Author)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
            entity.Property(e => e.Price).HasColumnType("decimal(10, 2)");
            entity.Property(e => e.Title)
                .HasMaxLength(20)
                .IsUnicode(false);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
