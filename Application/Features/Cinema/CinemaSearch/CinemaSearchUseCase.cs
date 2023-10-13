
using System.Collections.Generic;
using System.Linq;
using MovieManagementAPI.Domain.Entities;
using MovieManagementAPI.Domain.Interfaces;

namespace MovieManagementAPI.Application.Features.Cinema.CinemaSearch
{
    public class CinemaSearchUseCase
    {
        private readonly ICinemaRepository _cinemaRepository;

        public CinemaSearchUseCase(ICinemaRepository cinemaRepository)
        {
            _cinemaRepository = cinemaRepository;
        }

        public List<Domain.Entities.Cinema> SearchCinemas(string searchCriteria)
        {
            // Example: Implement search logic based on name or location
            return _cinemaRepository.GetAllCinemas()
                .Where(c => c.Name.Contains(searchCriteria) || c.Location.Contains(searchCriteria))
                .ToList();
        }
    }
}
