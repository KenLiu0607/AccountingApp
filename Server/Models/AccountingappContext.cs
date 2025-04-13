using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Server.Models;

public partial class AccountingappContext : DbContext
{
    public AccountingappContext()
    {
    }

    public AccountingappContext(DbContextOptions<AccountingappContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Category> Categories { get; set; }

    public virtual DbSet<Transaction> Transactions { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=LIN\\SQLEXPRESS;Database=ACCOUNTINGAPP;Trusted_Connection=True;Encrypt=False");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Category>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Categori__3214EC07054714DC");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Name).HasDefaultValue("");
            entity.Property(e => e.Type)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValue("");
        });

        modelBuilder.Entity<Transaction>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Transact__3214EC071BF451F8");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Amount).HasColumnType("decimal(10, 2)");
            entity.Property(e => e.CategoryId).HasColumnName("CategoryID");
            entity.Property(e => e.CreateDate).HasDefaultValueSql("(getdate())");
            entity.Property(e => e.CreateUser)
                .HasMaxLength(20)
                .HasDefaultValue("Ken");
            entity.Property(e => e.EditDate).HasDefaultValueSql("(getdate())");
            entity.Property(e => e.EditUser)
                .HasMaxLength(20)
                .HasDefaultValue("Ken");
            entity.Property(e => e.Note).HasDefaultValue("");
            entity.Property(e => e.Title).HasDefaultValue("");
            entity.Property(e => e.TransDate).HasDefaultValueSql("(getdate())");
            entity.Property(e => e.TransUser)
                .HasMaxLength(20)
                .HasDefaultValue("");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
