using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace AppVacunas.Server
{
    public partial class dfd2guu5v5usvlContext : DbContext
    {
        public dfd2guu5v5usvlContext()
        {
        }

        public dfd2guu5v5usvlContext(DbContextOptions<dfd2guu5v5usvlContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Direccion> Direcciones { get; set; }
        public virtual DbSet<Pais> Pais { get; set; }
        public virtual DbSet<Persona> Personas { get; set; }
        public virtual DbSet<Provincia> Provincia { get; set; }
        public virtual DbSet<Vacuna> Vacunas { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "en_US.UTF-8");

            modelBuilder.Entity<Direccion>(entity =>
            {
                entity.ToTable("direccion");

                entity.Property(e => e.Id)
                    .HasColumnName("direccion_id")
                    .UseIdentityAlwaysColumn();

                entity.Property(e => e.Calle)
                    .HasMaxLength(150)
                    .HasColumnName("calle");

                entity.Property(e => e.Latitud).HasColumnName("latitud");

                entity.Property(e => e.Logitud).HasColumnName("logitud");

                entity.Property(e => e.PaisId).HasColumnName("pais_id");

                entity.Property(e => e.ProvinciaId).HasColumnName("provincia_id");

                entity.Property(e => e.Sector)
                    .HasMaxLength(100)
                    .HasColumnName("sector");

                entity.HasOne(d => d.Pais)
                    .WithMany(p => p.Direcciones)
                    .HasForeignKey(d => d.PaisId)
                    .HasConstraintName("fk_direccion_pais");

                entity.HasOne(d => d.Provincia)
                    .WithMany(p => p.Direcciones)
                    .HasForeignKey(d => d.ProvinciaId)
                    .HasConstraintName("fk_direccion_provincia");
            });

            modelBuilder.Entity<Pais>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .HasName("pais_pkey");

                entity.ToTable("pais");

                entity.Property(e => e.Id)
                    .HasColumnName("pais_id")
                    .UseIdentityAlwaysColumn();

                entity.Property(e => e.NombrePais)
                    .IsRequired()
                    .HasMaxLength(150)
                    .HasColumnName("nombre_pais");
            });

            modelBuilder.Entity<Persona>(entity =>
            {
                entity.ToTable("persona");

                entity.Property(e => e.Id)
                    .HasColumnName("persona_id")
                    .UseIdentityAlwaysColumn();

                entity.Property(e => e.Apellido1)
                    .HasMaxLength(80)
                    .HasColumnName("apellido1");

                entity.Property(e => e.Apellido2)
                    .HasMaxLength(80)
                    .HasColumnName("apellido2");

                entity.Property(e => e.Cedula)
                    .HasMaxLength(11)
                    .HasColumnName("cedula");

                entity.Property(e => e.DireccionId).HasColumnName("direccion_id");

                entity.Property(e => e.EstatusVacuna).HasColumnName("estatus_vacuna");

                entity.Property(e => e.FechaDosis1)
                    .HasColumnType("date")
                    .HasColumnName("fecha_dosis1");

                entity.Property(e => e.FechaDosis2)
                    .HasColumnType("date")
                    .HasColumnName("fecha_dosis2");

                entity.Property(e => e.FechaNacimiento)
                    .HasColumnType("date")
                    .HasColumnName("fecha_nacimiento");

                entity.Property(e => e.Nombres)
                    .HasMaxLength(80)
                    .HasColumnName("nombres");

                entity.Property(e => e.Telefono)
                    .HasMaxLength(15)
                    .HasColumnName("telefono");

                entity.Property(e => e.VacunaId).HasColumnName("vacuna_id");

                entity.HasOne(d => d.Direccion)
                    .WithMany(p => p.Personas)
                    .HasForeignKey(d => d.DireccionId)
                    .HasConstraintName("fk_persona_direccion");

                entity.HasOne(d => d.Vacuna)
                    .WithMany(p => p.Personas)
                    .HasForeignKey(d => d.VacunaId)
                    .HasConstraintName("fk_persona_vacuna");
            });

            modelBuilder.Entity<Provincia>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .HasName("provincia_pkey");

                entity.ToTable("provincia");

                entity.Property(e => e.Id)
                    .HasColumnName("provincia_id")
                    .UseIdentityAlwaysColumn();

                entity.Property(e => e.NombreProvincia)
                    .IsRequired()
                    .HasMaxLength(150)
                    .HasColumnName("nombre_provincia");

                entity.Property(e => e.PaisId).HasColumnName("pais_id");

                entity.HasOne(d => d.Pais)
                    .WithMany(p => p.Provincia)
                    .HasForeignKey(d => d.PaisId)
                    .HasConstraintName("fk_provincia_pais");
            });

            modelBuilder.Entity<Vacuna>(entity =>
            {
                entity.ToTable("vacuna");

                entity.Property(e => e.Id)
                    .HasColumnName("vacuna_id")
                    .UseIdentityAlwaysColumn();

                entity.Property(e => e.CantidadDias).HasColumnName("cantidad_dias");

                entity.Property(e => e.CantidadVacuna).HasColumnName("cantidad_vacuna");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(150)
                    .HasColumnName("nombre");

                entity.Property(e => e.NombreOrganizacion)
                    .HasMaxLength(150)
                    .HasColumnName("nombre_organizacion");

                entity.Property(e => e.PaisId).HasColumnName("pais_id");

                entity.HasOne(d => d.Pais)
                    .WithMany(p => p.Vacunas)
                    .HasForeignKey(d => d.PaisId)
                    .HasConstraintName("fk_vacuna_pais");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
