using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using MovieManagementAPI.Domain.Entities;
using MovieManagementAPI.Domain.Interfaces;
using MovieManagementAPI.Infrastructure.Persistence;

namespace MovieManagementAPI.Infrastructure.Persistence.Repositories
{
    public class CinemaRepository : ICinemaRepository
    {
        private readonly ApplicationDbContext _context;

        public CinemaRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public List<Cinema> GetAllCinemas()
        {
            return _context.Cinemas.ToList();
        }

        public Cinema GetCinemaById(int id)
        {
            return _context.Cinemas.FirstOrDefault(c => c.Id == id);
        }

        public void AddCinema(Cinema cinema)
        {
            _context.Cinemas.Add(cinema);
            _context.SaveChanges();
        }

        public void UpdateCinema(Cinema cinema)
        {
            _context.Entry(cinema).State = EntityState.Modified;
            _context.SaveChanges();
        }
    }
}
