
using MovieManagementAPI.Domain.Entities;
using MovieManagementAPI.Domain.Interfaces;

namespace MovieManagementAPI.Application.Features.Movie.MovieUpdate
{
    public class MovieUpdateUseCase
    {
        private readonly IMovieRepository _movieRepository;

        public MovieUpdateUseCase(IMovieRepository movieRepository)
        {
            _movieRepository = movieRepository;
        }

        public void UpdateMovie(Domain.Entities.Movie movie)
        {
            _movieRepository.UpdateMovie(movie);
        }
    }
}
