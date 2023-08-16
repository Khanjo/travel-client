using System.Text.Json.Serialization;

namespace TravelClient.Models
{
    public class Review
    {
        public int ReviewId { get; set; }
        public string Title { get; set; }
        public string Text { get; set; }
        public int Rating { get; set; }
        public string User { get; set; }
        public int DestinationId { get; set; }
        [JsonIgnore]
        public Destination Destination { get; set; }
    }
}