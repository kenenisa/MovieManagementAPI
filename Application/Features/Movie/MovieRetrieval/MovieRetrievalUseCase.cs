
using System.Collections.Generic;
using MovieManagementAPI.Domain.Entities;
using MovieManagementAPI.Domain.Interfaces;

namespace MovieManagementAPI.Application.Features.Movie.MovieRetrieval
{
    public class MovieRetrievalUseCase
    {
        private readonly IMovieRepository _movieRepository;

        public MovieRetrievalUseCase(IMovieRepository movieRepository)
        {
            _movieRepository = movieRepository;
        }

        public List<Movie> GetAllMovies()
        {
            return _movieRepository.GetAllMovies();
        }

        public Movie GetMovieById(int id)
        {
            return _movieRepository.GetMovieById(id);
        }
    }
}
