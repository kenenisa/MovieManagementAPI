using Microsoft.AspNetCore.Mvc;
using MovieManagementAPI.Application.Features.Movie.MovieCreation;
using MovieManagementAPI.Application.Features.Movie.MovieRetrieval;
using MovieManagementAPI.Application.Features.Movie.MovieSearch;
using MovieManagementAPI.Application.Features.Movie.MovieUpdate;
using MovieManagementAPI.Domain.Entities;

namespace MovieManagementAPI.Web.Controllers
{
    [Route("api/movies")]
    [ApiController]
    public class MovieController : ControllerBase
    {
        private readonly MovieCreationUseCase _creationUseCase;
        private readonly MovieRetrievalUseCase _retrievalUseCase;
        private readonly MovieUpdateUseCase _updateUseCase;
        private readonly MovieSearchUseCase _searchUseCase;

        public MovieController(
            MovieCreationUseCase creationUseCase,
            MovieRetrievalUseCase retrievalUseCase,
            MovieUpdateUseCase updateUseCase,
            MovieSearchUseCase searchUseCase)
        {
            _creationUseCase = creationUseCase;
            _retrievalUseCase = retrievalUseCase;
            _updateUseCase = updateUseCase;
            _searchUseCase = searchUseCase;
        }

        [HttpGet]
        public IActionResult GetMovies()
        {
            var movies = _retrievalUseCase.GetAllMovies();
            return Ok(movies);
        }

        [HttpGet("{id}")]
        public IActionResult GetMovieById(int id)
        {
            var movie = _retrievalUseCase.GetMovieById(id);

            if (movie == null)
                return NotFound();

            return Ok(movie);
        }

        [HttpPost]
        public IActionResult CreateMovie([FromBody] MovieCreationRequest request)
        {
            var movie = new Movie
            {
                Title = request.Title,
                Genre = request.Genre,
                ReleaseYear = request.ReleaseYear
            };

            _creationUseCase.CreateMovie(movie);

            return CreatedAtAction(nameof(GetMovieById), new { id = movie.Id }, movie);
        }

        [HttpPut("{id}")]
        public IActionResult UpdateMovie(int id, [FromBody] MovieUpdateRequest request)
        {
            var existingMovie = _retrievalUseCase.GetMovieById(id);

            if (existingMovie == null)
                return NotFound();

            existingMovie.Title = request.Title;
            existingMovie.Genre = request.Genre;
            existingMovie.ReleaseYear = request.ReleaseYear;

            _updateUseCase.UpdateMovie(existingMovie);

            return NoContent();
        }

        [HttpGet("search")]
        public IActionResult SearchMovies([FromQuery] string searchCriteria)
        {
            var movies = _searchUseCase.SearchMovies(searchCriteria);
            return Ok(movies);
        }
    }
}
