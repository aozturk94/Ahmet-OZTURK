using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace myEntityFrameWorkProject_01.Models
{
    public partial class aKutuphaneContext : DbContext
    {
        public aKutuphaneContext()
        {
        }

        public aKutuphaneContext(DbContextOptions<aKutuphaneContext> options)
            : base(options)
        {
        }

        public virtual DbSet<TblKitaplar> TblKitaplars { get; set; }
        public virtual DbSet<TblOdunc> TblOduncs { get; set; }
        public virtual DbSet<TblTurler> TblTurlers { get; set; }
        public virtual DbSet<TblUyeler> TblUyelers { get; set; }
        public virtual DbSet<TblYayinevleri> TblYayinevleris { get; set; }
        public virtual DbSet<TblYazarlar> TblYazarlars { get; set; }
        public virtual DbSet<ViewKitaplar> ViewKitaplars { get; set; }
        public virtual DbSet<ViewOdunc> ViewOduncs { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=OZTURK; Database=aKutuphane; User=sa; Pwd=123;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Turkish_CI_AS");

            modelBuilder.Entity<TblKitaplar>(entity =>
            {
                entity.HasKey(e => e.Isbn)
                    .HasName("PK__tblKitap__447D36EBDB63913C");

                entity.ToTable("tblKitaplar");

                entity.Property(e => e.Isbn).HasColumnName("ISBN");

                entity.Property(e => e.KitapAd)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.KitapSayfaSayisi)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.KitapStokAdedi)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.TurId).HasColumnName("TurID");

                entity.Property(e => e.YayinEviId).HasColumnName("YayinEviID");

                entity.Property(e => e.YazarId).HasColumnName("YazarID");

                entity.HasOne(d => d.Tur)
                    .WithMany(p => p.TblKitaplars)
                    .HasForeignKey(d => d.TurId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__tblKitapl__TurID__5812160E");

                entity.HasOne(d => d.YayinEvi)
                    .WithMany(p => p.TblKitaplars)
                    .HasForeignKey(d => d.YayinEviId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__tblKitapl__Yayin__59FA5E80");

                entity.HasOne(d => d.Yazar)
                    .WithMany(p => p.TblKitaplars)
                    .HasForeignKey(d => d.YazarId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__tblKitapl__Yazar__59063A47");
            });

            modelBuilder.Entity<TblOdunc>(entity =>
            {
                entity.ToTable("tblOdunc");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.KitapIsbn).HasColumnName("KitapISBN");

                entity.Property(e => e.OduncVerilmeTarihi)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.TeslimEdilmesiGerekenTarih)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.TeslimTarihi)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.UyeId).HasColumnName("UyeID");

                entity.HasOne(d => d.KitapIsbnNavigation)
                    .WithMany(p => p.TblOduncs)
                    .HasForeignKey(d => d.KitapIsbn)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__tblOdunc__Teslim__5CD6CB2B");

                entity.HasOne(d => d.Uye)
                    .WithMany(p => p.TblOduncs)
                    .HasForeignKey(d => d.UyeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__tblOdunc__UyeID__5DCAEF64");
            });

            modelBuilder.Entity<TblTurler>(entity =>
            {
                entity.ToTable("tblTurler");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.TurAd)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblUyeler>(entity =>
            {
                entity.ToTable("tblUyeler");

                entity.HasIndex(e => e.UyeTc, "UQ__tblUyele__76F673510F9F778D")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.UyeAd)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.UyeMail)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.UyeSoyad)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.UyeTc)
                    .IsRequired()
                    .HasMaxLength(11)
                    .IsUnicode(false)
                    .HasColumnName("UyeTC")
                    .IsFixedLength(true);

                entity.Property(e => e.UyeTel)
                    .IsRequired()
                    .HasMaxLength(16)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblYayinevleri>(entity =>
            {
                entity.ToTable("tblYayinevleri");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.YayineviAd)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.YayineviAdres)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.YayineviTel)
                    .HasMaxLength(16)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblYazarlar>(entity =>
            {
                entity.ToTable("tblYazarlar");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.YazarAd)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.YazarCinsiyet)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.YazarDogumTarihi)
                    .IsRequired()
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.YazarMail)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.YazarSoyad)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.YazarTel)
                    .HasMaxLength(16)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ViewKitaplar>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("viewKitaplar");

                entity.Property(e => e.Isbn).HasColumnName("ISBN");

                entity.Property(e => e.KitapAd)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.KitapSayfaSayisi)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.KitapStokAdedi)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.TurAd)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.YayineviAd)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.YazarAd)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.YazarSoyad)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ViewOdunc>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("viewOdunc");

                entity.Property(e => e.Isbn).HasColumnName("ISBN");

                entity.Property(e => e.KitapAd)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.OduncVerilmeTarihi)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.TeslimEdilmesiGerekenTarih)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.TeslimTarihi)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.UyeAd)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.UyeSoyad)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.UyeTc)
                    .IsRequired()
                    .HasMaxLength(11)
                    .IsUnicode(false)
                    .HasColumnName("UyeTC")
                    .IsFixedLength(true);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
