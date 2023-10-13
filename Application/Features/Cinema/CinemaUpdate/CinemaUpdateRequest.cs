
namespace MovieManagementAPI.Application.Features.Cinema.CinemaUpdate
{
    public class CinemaUpdateRequest
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }
        public string ContactInformation { get; set; }
    }
}
