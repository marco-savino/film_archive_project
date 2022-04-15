using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace backend.Models
{
    public partial class archivio_filmContext : DbContext
    {
        public archivio_filmContext()
        {
        }

        public archivio_filmContext(DbContextOptions<archivio_filmContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Attore> Attores { get; set; }
        public virtual DbSet<Direzione> Direziones { get; set; }
        public virtual DbSet<Film> Films { get; set; }
        public virtual DbSet<Interpretazione> Interpretaziones { get; set; }
        public virtual DbSet<Registum> Regista { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseMySQL("Server=localhost;Database=archivio_film;Uid=root;Pwd=admin;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Attore>(entity =>
            {
                entity.ToTable("attore");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Cognome)
                    .HasMaxLength(50)
                    .HasColumnName("cognome");

                entity.Property(e => e.Nome)
                    .HasMaxLength(50)
                    .HasColumnName("nome");
            });

            modelBuilder.Entity<Direzione>(entity =>
            {
                entity.ToTable("direzione");

                entity.HasIndex(e => e.IdFilm, "idFilm");

                entity.HasIndex(e => e.IdRegista, "idRegista");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.IdFilm).HasColumnName("idFilm");

                entity.Property(e => e.IdRegista).HasColumnName("idRegista");

                entity.HasOne(d => d.IdFilmNavigation)
                    .WithMany(p => p.Direziones)
                    .HasForeignKey(d => d.IdFilm)
                    .HasConstraintName("direzione_ibfk_2");

                entity.HasOne(d => d.IdRegistaNavigation)
                    .WithMany(p => p.Direziones)
                    .HasForeignKey(d => d.IdRegista)
                    .HasConstraintName("direzione_ibfk_1");
            });

            modelBuilder.Entity<Film>(entity =>
            {
                entity.ToTable("film");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Durata).HasColumnName("durata");

                entity.Property(e => e.Genere)
                    .HasMaxLength(50)
                    .HasColumnName("genere");

                entity.Property(e => e.Titolo)
                    .HasMaxLength(50)
                    .HasColumnName("titolo");
            });

            modelBuilder.Entity<Interpretazione>(entity =>
            {
                entity.ToTable("interpretazione");

                entity.HasIndex(e => e.IdAttore, "idAttore");

                entity.HasIndex(e => e.IdFilm, "idFilm");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.IdAttore).HasColumnName("idAttore");

                entity.Property(e => e.IdFilm).HasColumnName("idFilm");

                entity.Property(e => e.Protagonista).HasColumnName("protagonista");

                entity.HasOne(d => d.IdAttoreNavigation)
                    .WithMany(p => p.Interpretaziones)
                    .HasForeignKey(d => d.IdAttore)
                    .HasConstraintName("interpretazione_ibfk_2");

                entity.HasOne(d => d.IdFilmNavigation)
                    .WithMany(p => p.Interpretaziones)
                    .HasForeignKey(d => d.IdFilm)
                    .HasConstraintName("interpretazione_ibfk_1");
            });

            modelBuilder.Entity<Registum>(entity =>
            {
                entity.ToTable("regista");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Cognome)
                    .HasMaxLength(50)
                    .HasColumnName("cognome");

                entity.Property(e => e.Nome)
                    .HasMaxLength(50)
                    .HasColumnName("nome");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
