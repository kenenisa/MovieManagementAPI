
using System.Collections.Generic;
using MovieManagementAPI.Domain.Entities;

namespace MovieManagementAPI.Application.Features.Movie.MovieSearch
{
    public class MovieSearchResponse
    {
        public List<Movie> Movies { get; set; }
    }
}
