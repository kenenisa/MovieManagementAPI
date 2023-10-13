
using Microsoft.AspNetCore.Mvc;
using MovieManagementAPI.Application.Features.Cinema.CinemaCreation;
using MovieManagementAPI.Application.Features.Cinema.CinemaRetrieval;
using MovieManagementAPI.Application.Features.Cinema.CinemaSearch;
using MovieManagementAPI.Application.Features.Cinema.CinemaUpdate;
using MovieManagementAPI.Domain.Entities;

namespace MovieManagementAPI.Web.Controllers
{
    [Route("api/cinemas")]
    [ApiController]
    public class CinemaController : ControllerBase
    {
        private readonly CinemaCreationUseCase _creationUseCase;
        private readonly CinemaRetrievalUseCase _retrievalUseCase;
        private readonly CinemaUpdateUseCase _updateUseCase;
        private readonly CinemaSearchUseCase _searchUseCase;

        public CinemaController(
            CinemaCreationUseCase creationUseCase,
            CinemaRetrievalUseCase retrievalUseCase,
            CinemaUpdateUseCase updateUseCase,
            CinemaSearchUseCase searchUseCase)
        {
            _creationUseCase = creationUseCase;
            _retrievalUseCase = retrievalUseCase;
            _updateUseCase = updateUseCase;
            _searchUseCase = searchUseCase;
        }

        [HttpGet]
        public IActionResult GetCinemas()
        {
            var cinemas = _retrievalUseCase.GetAllCinemas();
            return Ok(cinemas);
        }

        [HttpGet("{id}")]
        public IActionResult GetCinemaById(int id)
        {
            var cinema = _retrievalUseCase.GetCinemaById(id);

            if (cinema == null)
                return NotFound();

            return Ok(cinema);
        }

        [HttpPost]
        public IActionResult CreateCinema([FromBody] CinemaCreationRequest request)
        {
            var cinema = new Cinema
            {
                Name = request.Name,
                Location = request.Location,
                ContactInformation = request.ContactInformation
            };

            _creationUseCase.CreateCinema(cinema);

            return CreatedAtAction(nameof(GetCinemaById), new { id = cinema.Id }, cinema);
        }

        [HttpPut("{id}")]
        public IActionResult UpdateCinema(int id, [FromBody] CinemaUpdateRequest request)
        {
            var existingCinema = _retrievalUseCase.GetCinemaById(id);

            if (existingCinema == null)
                return NotFound();

            existingCinema.Name = request.Name;
            existingCinema.Location = request.Location;
            existingCinema.ContactInformation = request.ContactInformation;

            _updateUseCase.UpdateCinema(existingCinema);

            return NoContent();
        }

        [HttpGet("search")]
        public IActionResult SearchCinemas([FromQuery] string searchCriteria)
        {
            var cinemas = _searchUseCase.SearchCinemas(searchCriteria);
            return Ok(cinemas);
        }
    }
}
