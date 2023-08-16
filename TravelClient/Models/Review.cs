using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using JsonIgnoreAttribute = System.Text.Json.Serialization.JsonIgnoreAttribute;

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

        public static List<Review> GetReviews()
        {
            var apiCallTask = ApiHelper.GetAllReviews();
            var result = apiCallTask.Result;

            JArray jsonResponse = JsonConvert.DeserializeObject<JArray>(result);
            List<Review> reviewList = JsonConvert.DeserializeObject<List<Review>>(jsonResponse.ToString());

            return reviewList;
        }

        public static Review GetDetails(int id)
        {
            var apiCallTask = ApiHelper.GetReview(id);
            var result = apiCallTask.Result;

            JObject jsonResponse = JsonConvert.DeserializeObject<JObject>(result);
            Review review = JsonConvert.DeserializeObject<Review>(jsonResponse.ToString());

            return review;
        }
    }
}