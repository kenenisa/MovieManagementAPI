using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using MovieManagementAPI.Domain.Entities;
using MovieManagementAPI.Domain.Interfaces;
using MovieManagementAPI.Infrastructure.Persistence;

namespace MovieManagementAPI.Infrastructure.Persistence.Repositories
{
    public class MovieRepository : IMovieRepository
    {
        private readonly ApplicationDbContext _context;

        public MovieRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public List<Movie> GetAllMovies()
        {
            return _context.Movies.ToList();
        }

        public Movie GetMovieById(int id)
        {
            return _context.Movies.FirstOrDefault(m => m.Id == id);
        }

        public void AddMovie(Movie movie)
        {
            _context.Movies.Add(movie);
            _context.SaveChanges();
        }

        public void UpdateMovie(Movie movie)
        {
            _context.Entry(movie).State = EntityState.Modified;
            _context.SaveChanges();
        }
    }
}
