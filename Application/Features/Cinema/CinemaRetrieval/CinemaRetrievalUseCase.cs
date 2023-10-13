
using System.Collections.Generic;
using MovieManagementAPI.Domain.Entities;
using MovieManagementAPI.Domain.Interfaces;

namespace MovieManagementAPI.Application.Features.Cinema.CinemaRetrieval
{
    public class CinemaRetrievalUseCase
    {
        private readonly ICinemaRepository _cinemaRepository;

        public CinemaRetrievalUseCase(ICinemaRepository cinemaRepository)
        {
            _cinemaRepository = cinemaRepository;
        }

        public List<Domain.Entities.Cinema> GetAllCinemas()
        {
            return _cinemaRepository.GetAllCinemas();
        }

        public Domain.Entities.Cinema GetCinemaById(int id)
        {
            return _cinemaRepository.GetCinemaById(id);
        }
    }
}
