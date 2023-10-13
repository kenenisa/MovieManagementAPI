
using System.Collections.Generic;
using MovieManagementAPI.Domain.Entities;

namespace MovieManagementAPI.Domain.Interfaces
{
    public interface ICinemaRepository
    {
        List<Cinema> GetAllCinemas();
        Cinema GetCinemaById(int id);
        void AddCinema(Cinema cinema);
        void UpdateCinema(Cinema cinema);
    }
}
