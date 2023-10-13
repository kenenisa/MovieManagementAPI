
namespace MovieManagementAPI.Application.Features.Movie.MovieCreation
{
    public class MovieCreationRequest
    {
        public string Title { get; set; }
        public string Genre { get; set; }
        public int ReleaseYear { get; set; }
    }
}
