
using MovieManagementAPI.Domain.Entities;
using MovieManagementAPI.Domain.Interfaces;

namespace MovieManagementAPI.Application.Features.Cinema.CinemaUpdate
{
    public class CinemaUpdateUseCase
    {
        private readonly ICinemaRepository _cinemaRepository;

        public CinemaUpdateUseCase(ICinemaRepository cinemaRepository)
        {
            _cinemaRepository = cinemaRepository;
        }

        public void UpdateCinema(Domain.Entities.Cinema cinema)
        {
            _cinemaRepository.UpdateCinema(cinema);
        }
    }
}
