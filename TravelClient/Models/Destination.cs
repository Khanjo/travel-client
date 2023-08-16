using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace TravelClient.Models
{
    public class Destination
    {
        public int DestinationId { get; set; }
        public string Name { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public List<Review> Reviews { get; set; }

        public static List<Destination> GetDestinations()
        {
            var apiCallTask = ApiHelper.GetAllDestinations();
            var result = apiCallTask.Result;

            JArray jsonResponse = JsonConvert.DeserializeObject<JArray>(result);
            List<Destination> destinationList = JsonConvert.DeserializeObject<List<Destination>>(jsonResponse.ToString());

            return destinationList;
        }

        public static Destination GetDetails(int id)
        {
            var apiCallTask = ApiHelper.GetDestination(id);
            var result = apiCallTask.Result;

            JObject jsonResponse = JsonConvert.DeserializeObject<JObject>(result);
            Destination destination = JsonConvert.DeserializeObject<Destination>(jsonResponse.ToString());

            return destination;
        }
    }
}