
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

        public List<Cinema> GetAllCinemas()
        {
            return _cinemaRepository.GetAllCinemas();
        }

        public Cinema GetCinemaById(int id)
        {
            return _cinemaRepository.GetCinemaById(id);
        }
    }
}
