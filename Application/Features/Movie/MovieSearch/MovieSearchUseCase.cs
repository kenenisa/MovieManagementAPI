
using System.Collections.Generic;
using System.Linq;
using MovieManagementAPI.Domain.Entities;
using MovieManagementAPI.Domain.Interfaces;

namespace MovieManagementAPI.Application.Features.Movie.MovieSearch
{
    public class MovieSearchUseCase
    {
        private readonly IMovieRepository _movieRepository;

        public MovieSearchUseCase(IMovieRepository movieRepository)
        {
            _movieRepository = movieRepository;
        }

        public List<Domain.Entities.Movie> SearchMovies(string searchCriteria)
        {
            // Example: Implement search logic based on title
            return _movieRepository.GetAllMovies().Where(m => m.Title.Contains(searchCriteria)).ToList();
        }
    }
}
