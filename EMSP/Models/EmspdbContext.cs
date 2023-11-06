using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace EMSP.Models;

public partial class EmspdbContext : DbContext
{
    public EmspdbContext()
    {
    }

    public EmspdbContext(DbContextOptions<EmspdbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Department> Departments { get; set; }

    public virtual DbSet<Employee> Employees { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("User ID=sa;password=examlyMssql@123;server=localhost;Database=EMSPDb;trusted_connection=false;Persist Security Info=false;Encrypt=false;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Department>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID");
            entity.Property(e => e.Name)
                .HasMaxLength(10)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Employee>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.EmpId)
                .ValueGeneratedOnAdd()
                .HasColumnName("EmpID");
            entity.Property(e => e.EmpName)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Salary).HasColumnName("salary");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
