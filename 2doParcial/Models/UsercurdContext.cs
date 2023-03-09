﻿using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace _2doParcial.Models;

public partial class UsercurdContext : DbContext
{
    public UsercurdContext()
    {
    }

    public UsercurdContext(DbContextOptions<UsercurdContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Usuario> Usuarios { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {

    }
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
  //      => optionsBuilder.UseSqlServer("server=localhost; database=USERCURD; integrated security=true; TrustServerCertificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Usuario>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__USUARIOS__3214EC074521226E");

            entity.ToTable("USUARIOS");

            entity.Property(e => e.Apellido)
                .HasMaxLength(25)
                .IsUnicode(false);
            entity.Property(e => e.Carrera)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Nombre)
                .HasMaxLength(20)
                .IsUnicode(false);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
