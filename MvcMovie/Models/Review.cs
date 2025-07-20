using Microsoft.EntityFrameworkCore.Metadata.Conventions;

namespace MvcMovie.Models
{
    public class Review
    {
        public int Id { get; set; }
        public string? ReviewerName { get; set; }
        public string? Comments { get; set; }
        public int Rating { get; set; }
        public int MovieId { get; set; }
        public Movie? Movie { get; set; } // Navigation property to the Movie entity
    }
}
