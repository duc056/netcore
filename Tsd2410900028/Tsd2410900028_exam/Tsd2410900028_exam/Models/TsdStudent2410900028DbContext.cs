using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Tsd2410900028_exam.Models;

public partial class TsdStudent2410900028DbContext : DbContext
{
    public TsdStudent2410900028DbContext()
    {
    }

    public TsdStudent2410900028DbContext(DbContextOptions<TsdStudent2410900028DbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<TsdStudent> TsdStudents { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=.\\SQLEXPRESS;Database=TsdStudent2410900028Db;Trusted_Connection=True;MultipleActiveResultSets=True;TrustServerCertificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<TsdStudent>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__TsdStude__3214EC07549F7509");

            entity.ToTable("TsdStudent");

            entity.Property(e => e.TsdActive).HasDefaultValue(true);
            entity.Property(e => e.TsdEmail)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.TsdName).HasMaxLength(100);
            entity.Property(e => e.TsdPhone)
                .HasMaxLength(15)
                .IsUnicode(false);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
