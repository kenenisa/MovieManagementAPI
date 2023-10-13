
using System.Collections.Generic;
using MovieManagementAPI.Domain.Entities;

namespace MovieManagementAPI.Application.Features.Cinema.CinemaSearch
{
    public class CinemaSearchResponse
    {
        public List<Domain.Entities.Cinema> Cinemas { get; set; }
    }
}
