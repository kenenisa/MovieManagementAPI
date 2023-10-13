
using Microsoft.EntityFrameworkCore;
using MovieManagementAPI.Domain.Entities;

namespace MovieManagementAPI.Infrastructure.Persistence
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Movie> Movies { get; set; }
        public DbSet<Cinema> Cinemas { get; set; }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)

        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // base.OnModelCreating(modelBuilder);

            // // Seed Movies
            // modelBuilder.Entity<Movie>().HasData(
            //     new Movie { Id = 1, Title = "Movie 1", Genre = "Action", ReleaseYear = 2022 },
            //     new Movie { Id = 2, Title = "Movie 2", Genre = "Comedy", ReleaseYear = 2021 }
            //     // Add more movies as needed...
            // );

            // // Seed Cinemas
            // modelBuilder.Entity<Cinema>().HasData(
            //     new Cinema { Id = 1, Name = "Cinema A", Location = "Location A", ContactInformation = "123-456-7890" },
            //     new Cinema { Id = 2, Name = "Cinema B", Location = "Location B", ContactInformation = "987-654-3210" }
            //     // Add more cinemas as needed...
            // );
        }
    }
}