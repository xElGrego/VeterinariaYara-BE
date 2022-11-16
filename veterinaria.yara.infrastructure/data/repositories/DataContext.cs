using Microsoft.EntityFrameworkCore;
using veterinaria.yara.domain.entities;

namespace veterinaria.yara.infrastructure.data.repositories
{
    public partial class DataContext : DbContext
    {
  
        public DataContext()
        {
        }

        public DataContext(DbContextOptions<DataContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Mascota> Mascota { get; set; } = null!;
        public virtual DbSet<Persona> Personas { get; set; } = null!;
        public virtual DbSet<Raza> Razas { get; set; } = null!;



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Mascota>(entity =>
            {
                entity.HasKey(e => e.IdMascota)
                    .HasName("PK__Mascota__5C9C26F06CB7D585");

                entity.ToTable("Mascota", "VeterinariaGrego");

                entity.Property(e => e.Mote)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Nombre)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdRazaNavigation)
                    .WithMany(p => p.Mascota)
                    .HasForeignKey(d => d.IdRaza)
                    .HasConstraintName("FK_Mascota_Raza");
            });

            modelBuilder.Entity<Persona>(entity =>
            {
                entity.HasKey(e => e.IdPersona)
                    .HasName("PK__Persona__2EC8D2ACDD121F42");

                entity.ToTable("Persona", "VeterinariaGrego");

                entity.Property(e => e.Apellido)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.FechaCreacion).HasColumnType("datetime");

                entity.Property(e => e.FechaModificacion).HasColumnType("datetime");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdMascotaNavigation)
                    .WithMany(p => p.Personas)
                    .HasForeignKey(d => d.IdMascota)
                    .HasConstraintName("FK_Persona_Mascota");
            });

            modelBuilder.Entity<Raza>(entity =>
            {
                entity.HasKey(e => e.IdRaza)
                    .HasName("PK__Raza__8F06EB28B8E175B3");

                entity.ToTable("Raza", "VeterinariaGrego");

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Nombre)
                    .HasMaxLength(250)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }

}