
using System.Collections.Generic;
using MovieManagementAPI.Domain.Entities;

namespace MovieManagementAPI.Application.Features.Movie.MovieSearch
{
    public class MovieSearchResponse
    {
        public List<Domain.Entities.Movie> Movies { get; set; }
    }
}
