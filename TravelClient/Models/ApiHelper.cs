using System.Threading.Tasks;
using RestSharp;

namespace TravelClient.Models
{
    public class ApiHelper
    {
        public static async Task<string> GetAllDestinations()
        {
            RestClient client = new RestClient("http://localhost:5000/");
            RestRequest request = new RestRequest($"api/destinations", Method.Get);
            RestResponse response = await client.GetAsync(request);
            return response.Content;
        }

        public static async Task<string> GetDestination(int id)
        {
            RestClient client = new RestClient("http://localhost:5000/");
            RestRequest request = new RestRequest($"api/destinations/{id}", Method.Get);
            RestResponse response = await client.GetAsync(request);
            return response.Content;
        }

        public static async Task<string> GetAllReviews()
        {
            RestClient client = new RestClient("http://localhost:5000/");
            RestRequest request = new RestRequest($"api/reviews", Method.Get);
            RestResponse response = await client.GetAsync(request);
            return response.Content;
        }

        public static async Task<string> GetReview(int id)
        {
            RestClient client = new RestClient("http://localhost:5000/");
            RestRequest request = new RestRequest($"api/reviews/{id}", Method.Get);
            RestResponse response = await client.GetAsync(request);
            return response.Content;
        }
    }
}