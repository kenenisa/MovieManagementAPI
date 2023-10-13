
using System.Collections.Generic;
using MovieManagementAPI.Domain.Entities;

namespace MovieManagementAPI.Domain.Interfaces
{
    public interface IMovieRepository
    {
        List<Movie> GetAllMovies();
        Movie GetMovieById(int id);
        void AddMovie(Movie movie);
        void UpdateMovie(Movie movie);
    }
}
