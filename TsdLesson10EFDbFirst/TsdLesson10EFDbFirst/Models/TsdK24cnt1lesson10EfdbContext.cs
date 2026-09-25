using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace TsdLesson10EFDbFirst.Models;

public partial class TsdK24cnt1lesson10EfdbContext : DbContext
{
    public TsdK24cnt1lesson10EfdbContext()
    {
    }

    public TsdK24cnt1lesson10EfdbContext(DbContextOptions<TsdK24cnt1lesson10EfdbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<TsdMember> TsdMembers { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=.\\SQLEXPRESS;Database=TsdK24CNT1Lesson10EFDb;Trusted_Connection=True;MultipleActiveResultSets=True;TrustServerCertificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<TsdMember>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("TsdMember");

            entity.Property(e => e.TsdEmail)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.TsdFullName).HasMaxLength(50);
            entity.Property(e => e.TsdPassword)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.TsdPhone)
                .HasMaxLength(12)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.TsdUserName)
                .HasMaxLength(20)
                .IsUnicode(false);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
