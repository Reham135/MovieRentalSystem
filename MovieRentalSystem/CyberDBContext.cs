using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;
using MovieRentalSystem.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace MovieRentalSystem
{
    public class CyberDBContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.;DataBase=CyberDB;Trusted_Connection=True;Encrypt=False");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            #region Customer
            modelBuilder.Entity<Customer>().HasKey(ww => ww.Id);
            modelBuilder.Entity<Customer>().Property(ww => ww.FirstName).IsRequired().HasColumnType("varchar(255)");
            modelBuilder.Entity<Customer>().Property(ww => ww.LastName).IsRequired().HasColumnType("varchar(255)");
            modelBuilder.Entity<Customer>().Property(ww => ww.Address).IsRequired().HasColumnType("varchar(255)");
            modelBuilder.Entity<Customer>().Property(ww => ww.PhoneNumber).IsRequired().HasMaxLength(10);
            modelBuilder.Entity<Customer>().Property(ww => ww.BirthDate).IsRequired(false);
            #endregion

            #region Movie
            modelBuilder.Entity<Movie>().HasKey(ww => ww.Id);
            modelBuilder.Entity<Movie>().Property(ww => ww.Title).IsRequired().HasColumnType("varchar(255)");
            modelBuilder.Entity<Movie>().Property(ww => ww.Duration).IsRequired().HasMaxLength(10);
            modelBuilder.Entity<Movie>().Property(ww => ww.Rating).IsRequired(false);
            modelBuilder.Entity<Movie>().Property(ww => ww.ProducerId).IsRequired().HasMaxLength(10);
            modelBuilder.Entity<Movie>()               //configure relationship one to many
               .HasOne(ww => ww.Producer)
               .WithMany(ww => ww.Movies)
               .HasForeignKey(ww => ww.ProducerId);
            #endregion

            #region MovieCustomer
            modelBuilder.Entity<MovieCustomer>().HasKey(ww => new {ww.MovieId,ww.CustomerId}); //composite P.k
            modelBuilder.Entity<MovieCustomer>().Property(ww => ww.Date_Rented).IsRequired();
            modelBuilder.Entity<MovieCustomer>().Property(ww => ww.Due_Date).IsRequired();
            modelBuilder.Entity<MovieCustomer>()        //configure relationship many to many
                .HasOne(ww => ww.Customer)
                .WithMany(ww => ww.CustomerMovies)
                .HasForeignKey(ww => ww.CustomerId);
            modelBuilder.Entity<MovieCustomer>()
                .HasOne(ww => ww.Movie)
                .WithMany(ww => ww.MovieCustomers)
                .HasForeignKey(ww => ww.MovieId);
            #endregion

            #region Producer
            modelBuilder.Entity<Producer>().HasKey(ww => ww.Id);
            modelBuilder.Entity<Producer>().Property(WW => WW.CompanyName).IsRequired().HasColumnType("varchar(200)");
            modelBuilder.Entity<Producer>().Property(WW => WW.Country).IsRequired().HasColumnType("varchar(255)");

            #endregion

            #region MovieFeedback

            modelBuilder.Entity<MovieFeedback>()
                .HasKey(x => new { x.MovieId, x.CustomerId });
            modelBuilder.Entity<MovieFeedback>()
                .HasOne(x => x.Customer)
                .WithMany()
                .HasForeignKey(x => x.CustomerId);
            modelBuilder.Entity<MovieFeedback>()
                .HasOne(x => x.Movie)
                .WithMany()
                .HasForeignKey(x => x.MovieId);

            #endregion

        }


        public DbSet<Customer> Customers { get; set; }
        public DbSet<Movie> Movies { get; set; }
        public DbSet<MovieCustomer> MovieCustomers { get; set; }
        public DbSet<Producer> Producers { get; set; }

    }
}
