
namespace MovieManagementAPI.Application.Features.Movie.MovieUpdate
{
    public class MovieUpdateRequest
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Genre { get; set; }
        public int ReleaseYear { get; set; }
    }
}
