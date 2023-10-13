
using MovieManagementAPI.Domain.Entities;
using MovieManagementAPI.Domain.Interfaces;

namespace MovieManagementAPI.Application.Features.Movie.MovieCreation
{
    public class MovieCreationUseCase
    {
        private readonly IMovieRepository _movieRepository;

        public MovieCreationUseCase(IMovieRepository movieRepository)
        {
            _movieRepository = movieRepository;
        }

        public void CreateMovie(Domain.Entities.Movie movie)
        {
            _movieRepository.AddMovie(movie);
        }
    }
}
