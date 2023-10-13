
using MovieManagementAPI.Domain.Entities;
using MovieManagementAPI.Domain.Interfaces;

namespace MovieManagementAPI.Application.Features.Cinema.CinemaCreation
{
    public class CinemaCreationUseCase
    {
        private readonly ICinemaRepository _cinemaRepository;

        public CinemaCreationUseCase(ICinemaRepository cinemaRepository)
        {
            _cinemaRepository = cinemaRepository;
        }

        public void CreateCinema(Domain.Entities.Cinema cinema)
        {
            _cinemaRepository.AddCinema(cinema);
        }
    }
}
