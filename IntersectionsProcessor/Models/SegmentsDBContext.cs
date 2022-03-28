using System;
using System.Collections.Generic;
using System.Configuration;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace IntersectionsProcessor.Models
{
    //Автоссгенерированный класс командой Scaffold-DbContext
    public partial class SegmentsDBContext : DbContext
    {
        public SegmentsDBContext()
        {
        }

        public SegmentsDBContext(DbContextOptions<SegmentsDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Intersection> Intersections { get; set; } = null!;
        public virtual DbSet<SegmentDBEntity> Segments { get; set; } = null!;
        public virtual DbSet<Set> Sets { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                //Получение строки подключения к базе данных из конфигурационного файла
                string connectionString = ConfigurationManager.AppSettings.Get("ConnectionString");
                optionsBuilder.UseSqlServer(connectionString);
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Intersection>(entity =>
            {
                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.SetId).HasColumnName("SetID");

                entity.HasOne(d => d.Set)
                    .WithMany(p => p.Intersections)
                    .HasForeignKey(d => d.SetId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Intersections_Sets");
            });

            modelBuilder.Entity<SegmentDBEntity>(entity =>
            {
                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.SetId).HasColumnName("SetID");

                entity.HasOne(d => d.Set)
                    .WithMany(p => p.Segments)
                    .HasForeignKey(d => d.SetId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Segments_Sets");
            });

            modelBuilder.Entity<Set>(entity =>
            {
                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.Name)
                    .HasMaxLength(20)
                    .IsFixedLength();
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
