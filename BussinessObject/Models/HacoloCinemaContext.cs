﻿using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace BussinessObject.Models;

public partial class HacoloCinemaContext : DbContext
{
    public HacoloCinemaContext()
    {
    }

    public HacoloCinemaContext(DbContextOptions<HacoloCinemaContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Combo> Combos { get; set; }

    public virtual DbSet<Customer> Customers { get; set; }

    public virtual DbSet<Genre> Genres { get; set; }

    public virtual DbSet<Movie> Movies { get; set; }

    public virtual DbSet<Order> Orders { get; set; }

    public virtual DbSet<OrderDetailCombo> OrderDetailCombos { get; set; }

    public virtual DbSet<Payment> Payments { get; set; }

    public virtual DbSet<PricingSchedule> PricingSchedules { get; set; }

    public virtual DbSet<PromotionalMaterial> PromotionalMaterials { get; set; }

    public virtual DbSet<Seat> Seats { get; set; }

    public virtual DbSet<Showtime> Showtimes { get; set; }

    public virtual DbSet<Theater> Theaters { get; set; }

    public virtual DbSet<Ticket> Tickets { get; set; }

    public virtual DbSet<Wallet> Wallets { get; set; }

    public virtual DbSet<WalletTransaction> WalletTransactions { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("server =(local); database = HacoloCinema;uid=sa;pwd=123;TrustServerCertificate=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Combo>(entity =>
        {
            entity.HasKey(e => e.ComboId).HasName("PK__Combos__DD42582EF9EEB87D");

            entity.Property(e => e.ComboId).ValueGeneratedNever();
            entity.Property(e => e.ComboName).HasMaxLength(255);
            entity.Property(e => e.ComboPrice).HasColumnType("decimal(10, 0)");
        });

        modelBuilder.Entity<Customer>(entity =>
        {
            entity.HasKey(e => e.CustomerId).HasName("PK__Customer__A4AE64D84CC5564D");

            entity.Property(e => e.CustomerId).ValueGeneratedNever();
            entity.Property(e => e.CustomerName).HasMaxLength(255);
            entity.Property(e => e.Email)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Password)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.PhoneNumber)
                .HasMaxLength(20)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Genre>(entity =>
        {
            entity.HasKey(e => e.GenreId).HasName("PK__Genres__0385057EE6F65A4E");

            entity.Property(e => e.GenreId).ValueGeneratedNever();
            entity.Property(e => e.Description).HasColumnType("text");
            entity.Property(e => e.GenreName).HasMaxLength(255);
        });

        modelBuilder.Entity<Movie>(entity =>
        {
            entity.HasKey(e => e.MovieId).HasName("PK__Movies__4BD2941A7B2110CF");

            entity.Property(e => e.MovieId).ValueGeneratedNever();
            entity.Property(e => e.Cast).HasColumnType("text");
            entity.Property(e => e.Description).HasColumnType("text");
            entity.Property(e => e.Director)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.MovieName).HasMaxLength(255);

            entity.HasMany(d => d.Genres).WithMany(p => p.Movies)
                .UsingEntity<Dictionary<string, object>>(
                    "MovieGenre",
                    r => r.HasOne<Genre>().WithMany()
                        .HasForeignKey("GenreId")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK__MovieGenr__Genre__351DDF8C"),
                    l => l.HasOne<Movie>().WithMany()
                        .HasForeignKey("MovieId")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK__MovieGenr__Movie__3429BB53"),
                    j =>
                    {
                        j.HasKey("MovieId", "GenreId").HasName("PK__MovieGen__BBEAC44D51B02488");
                        j.ToTable("MovieGenre");
                    });
        });

        modelBuilder.Entity<Order>(entity =>
        {
            entity.HasKey(e => e.OrderId).HasName("PK__Orders__C3905BCF91438B47");

            entity.Property(e => e.OrderId).ValueGeneratedNever();
            entity.Property(e => e.OrderDate).HasColumnType("datetime");
            entity.Property(e => e.TotalPrice).HasColumnType("decimal(10, 0)");

            entity.HasOne(d => d.Customer).WithMany(p => p.Orders)
                .HasForeignKey(d => d.CustomerId)
                .HasConstraintName("FK__Orders__Customer__473C8FC7");

            entity.HasOne(d => d.Payment).WithMany(p => p.Orders)
                .HasForeignKey(d => d.PaymentId)
                .HasConstraintName("FK__Orders__PaymentI__46486B8E");
        });

        modelBuilder.Entity<OrderDetailCombo>(entity =>
        {
            entity.HasKey(e => new { e.OrderId, e.ComboId }).HasName("PK__OrderDet__3E447E4D582A6C67");

            entity.ToTable("OrderDetailCombo");

            entity.HasOne(d => d.Combo).WithMany(p => p.OrderDetailCombos)
                .HasForeignKey(d => d.ComboId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__OrderDeta__Combo__51BA1E3A");

            entity.HasOne(d => d.Order).WithMany(p => p.OrderDetailCombos)
                .HasForeignKey(d => d.OrderId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__OrderDeta__Order__50C5FA01");
        });

        modelBuilder.Entity<Payment>(entity =>
        {
            entity.HasKey(e => e.PaymentId).HasName("PK__Payment__9B556A38DCFFB151");

            entity.ToTable("Payment");

            entity.Property(e => e.PaymentId).ValueGeneratedNever();
            entity.Property(e => e.PaymentMethod)
                .HasMaxLength(255)
                .IsUnicode(false);
        });

        modelBuilder.Entity<PricingSchedule>(entity =>
        {
            entity.HasKey(e => e.PricingScheduleId).HasName("PK__PricingS__61C1BC09E3B96543");

            entity.ToTable("PricingSchedule");

            entity.Property(e => e.PricingScheduleId).ValueGeneratedNever();
            entity.Property(e => e.Description).HasColumnType("text");
            entity.Property(e => e.Price).HasColumnType("decimal(10, 0)");
        });

        modelBuilder.Entity<PromotionalMaterial>(entity =>
        {
            entity.HasKey(e => e.MaterialId).HasName("PK__Promotio__C5061317A980547D");

            entity.Property(e => e.MaterialId)
                .ValueGeneratedNever()
                .HasColumnName("MaterialID");
            entity.Property(e => e.FilePath)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.MovieId).HasColumnName("MovieID");
            entity.Property(e => e.Type)
                .HasMaxLength(255)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Seat>(entity =>
        {
            entity.HasKey(e => e.SeatId).HasName("PK__Seats__311713F3938B3FF5");

            entity.Property(e => e.SeatId).ValueGeneratedNever();
            entity.Property(e => e.SeatPosition)
                .HasMaxLength(255)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Showtime>(entity =>
        {
            entity.HasKey(e => e.ShowtimeId).HasName("PK__Showtime__32D31F207639BF88");

            entity.Property(e => e.ShowtimeId).ValueGeneratedNever();
            entity.Property(e => e.PricingScheduleId).HasColumnName("PricingScheduleID");

            entity.HasOne(d => d.Movie).WithMany(p => p.Showtimes)
                .HasForeignKey(d => d.MovieId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Showtimes__Movie__3DB3258D");

            entity.HasOne(d => d.PricingSchedule).WithMany(p => p.Showtimes)
                .HasForeignKey(d => d.PricingScheduleId)
                .HasConstraintName("FK__Showtimes__Prici__3F9B6DFF");

            entity.HasOne(d => d.Theater).WithMany(p => p.Showtimes)
                .HasForeignKey(d => d.TheaterId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Showtimes__Theat__3EA749C6");
        });

        modelBuilder.Entity<Theater>(entity =>
        {
            entity.HasKey(e => e.TheaterId).HasName("PK__Theaters__4D68B2191DBDADDC");

            entity.Property(e => e.TheaterId).ValueGeneratedNever();
            entity.Property(e => e.TheaterName).HasMaxLength(255);
        });

        modelBuilder.Entity<Ticket>(entity =>
        {
            entity.HasKey(e => e.TicketId).HasName("PK__Tickets__712CC607B448AF97");

            entity.Property(e => e.TicketId).ValueGeneratedNever();
            entity.Property(e => e.TicketPrice).HasColumnType("decimal(10, 0)");

            entity.HasOne(d => d.Order).WithMany(p => p.Tickets)
                .HasForeignKey(d => d.OrderId)
                .HasConstraintName("FK__Tickets__OrderId__4A18FC72");

            entity.HasOne(d => d.Seat).WithMany(p => p.Tickets)
                .HasForeignKey(d => d.SeatId)
                .HasConstraintName("FK__Tickets__SeatId__4C0144E4");

            entity.HasOne(d => d.Showtime).WithMany(p => p.Tickets)
                .HasForeignKey(d => d.ShowtimeId)
                .HasConstraintName("FK__Tickets__Showtim__4B0D20AB");
        });

        modelBuilder.Entity<Wallet>(entity =>
        {
            entity.HasKey(e => e.WalletId).HasName("PK__Wallet__84D4F90EDE336C21");

            entity.ToTable("Wallet");

            entity.Property(e => e.WalletId).ValueGeneratedNever();
            entity.Property(e => e.WalletBalance).HasColumnType("decimal(10, 0)");

            entity.HasOne(d => d.Customer).WithMany(p => p.Wallets)
                .HasForeignKey(d => d.CustomerId)
                .HasConstraintName("FK__Wallet__Customer__54968AE5");
        });

        modelBuilder.Entity<WalletTransaction>(entity =>
        {
            entity.HasKey(e => e.WalletTransactionId).HasName("PK__WalletTr__7184AEEFA979C319");

            entity.Property(e => e.WalletTransactionId).ValueGeneratedNever();
            entity.Property(e => e.TransactionAmount).HasColumnType("decimal(10, 0)");
            entity.Property(e => e.TransactionDate).HasColumnType("datetime");

            entity.HasOne(d => d.Wallet).WithMany(p => p.WalletTransactions)
                .HasForeignKey(d => d.WalletId)
                .HasConstraintName("FK__WalletTra__Walle__5772F790");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
