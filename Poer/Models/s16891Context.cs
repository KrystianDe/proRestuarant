using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Poer.Models
{
    public partial class s16891Context : DbContext
    {
        public s16891Context()
        {
        }

        public s16891Context(DbContextOptions<s16891Context> options)
            : base(options)
        {
        }

        public virtual DbSet<Admin> Admin { get; set; }
        public virtual DbSet<Administrato> Administrato { get; set; }
        public virtual DbSet<Administrator> Administrator { get; set; }
        public virtual DbSet<Adres> Adres { get; set; }
        public virtual DbSet<Dostawca> Dostawca { get; set; }
        public virtual DbSet<Klient> Klient { get; set; }
        public virtual DbSet<Lokal> Lokal { get; set; }
        public virtual DbSet<Osoba> Osoba { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Data Source=db-mssql;Initial Catalog=s16891;Integrated Security=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("ProductVersion", "2.2.6-servicing-10079");

            modelBuilder.Entity<Admin>(entity =>
            {
                entity.HasKey(e => e.IdAdmin)
                    .HasName("Admini_pk");

                entity.Property(e => e.IdAdmin)
                    .HasColumnName("id_Admin")
                    .ValueGeneratedNever();

                entity.Property(e => e.Login)
                    .IsRequired()
                    .HasColumnName("login")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.Mail)
                    .IsRequired()
                    .HasColumnName("mail")
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.Passoword)
                    .IsRequired()
                    .HasColumnName("passoword")
                    .HasMaxLength(34)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Administrato>(entity =>
            {
                entity.HasKey(e => e.IdAdmin)
                    .HasName("Administrato_pk");

                entity.Property(e => e.IdAdmin)
                    .HasColumnName("id_Admin")
                    .ValueGeneratedNever();

                entity.Property(e => e.Login)
                    .IsRequired()
                    .HasColumnName("login")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.Mail)
                    .IsRequired()
                    .HasColumnName("mail")
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.Passoword)
                    .IsRequired()
                    .HasColumnName("passoword")
                    .HasMaxLength(34)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Administrator>(entity =>
            {
                entity.HasKey(e => e.IdAdmin)
                    .HasName("Administrator_pk");

                entity.Property(e => e.IdAdmin)
                    .HasColumnName("id_Admin")
                    .ValueGeneratedNever();

                entity.Property(e => e.Login)
                    .IsRequired()
                    .HasColumnName("login")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.Mail)
                    .IsRequired()
                    .HasColumnName("mail")
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.Passoword)
                    .IsRequired()
                    .HasColumnName("passoword")
                    .HasMaxLength(34)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Adres>(entity =>
            {
                entity.HasKey(e => e.IdAdres)
                    .HasName("Adres_pk");

                entity.Property(e => e.IdAdres)
                    .HasColumnName("id_Adres")
                    .ValueGeneratedNever();

                entity.Property(e => e.Miasto)
                    .IsRequired()
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.NrDomu).HasColumnName("Nr_Domu");

                entity.Property(e => e.NrMieszkania).HasColumnName("Nr_mieszkania");

                entity.Property(e => e.Ulica)
                    .IsRequired()
                    .HasMaxLength(64)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Dostawca>(entity =>
            {
                entity.HasKey(e => e.IdDostawca)
                    .HasName("Dostawca_pk");

                entity.Property(e => e.IdDostawca)
                    .HasColumnName("id_Dostawca")
                    .ValueGeneratedNever();

                entity.Property(e => e.DataZatrudnienia)
                    .HasColumnName("data_zatrudnienia")
                    .HasColumnType("date");
            });

            modelBuilder.Entity<Klient>(entity =>
            {
                entity.HasKey(e => e.IdKlient)
                    .HasName("Klient_pk");

                entity.Property(e => e.IdKlient)
                    .HasColumnName("id_Klient")
                    .ValueGeneratedNever();

                entity.Property(e => e.Imie)
                    .IsRequired()
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.Mail)
                    .IsRequired()
                    .HasColumnName("mail")
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.Nazwisko)
                    .IsRequired()
                    .HasColumnName("nazwisko")
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.NumerTelefonu)
                    .IsRequired()
                    .HasColumnName("numer_telefonu")
                    .HasMaxLength(9)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Lokal>(entity =>
            {
                entity.HasKey(e => e.IdLokal)
                    .HasName("Lokal_pk");

                entity.Property(e => e.IdLokal)
                    .HasColumnName("Id_Lokal")
                    .ValueGeneratedNever();

                entity.Property(e => e.IdAdres).HasColumnName("id_Adres");

                entity.Property(e => e.Nazwa)
                    .IsRequired()
                    .HasColumnName("nazwa")
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.NumerTelefonu)
                    .IsRequired()
                    .HasColumnName("numer_telefonu")
                    .HasMaxLength(64)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Osoba>(entity =>
            {
                entity.HasKey(e => e.IdOsoba)
                    .HasName("Osoba_pk");

                entity.Property(e => e.IdOsoba)
                    .HasColumnName("id_Osoba")
                    .ValueGeneratedNever();

                entity.Property(e => e.Imie)
                    .IsRequired()
                    .HasColumnName("imie")
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.Nazwisko)
                    .IsRequired()
                    .HasColumnName("nazwisko")
                    .HasMaxLength(64)
                    .IsUnicode(false);
            });
        }
    }
}
