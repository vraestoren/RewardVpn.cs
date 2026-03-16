using System.Net.Http;
using System.Net.Http.Headers;

namespace RewardVpnApi
{
    public class RewardVpn
    {
        private readonly HttpClient httpClient;
        private readonly string apiUrl = "https://rewardsvpn.com/vpnadmin";
        
        public RewardVpn()
        {
            httpClient = new HttpClient();
            httpClient.DefaultRequestHeaders.UserAgent.ParseAdd(
                "Mozilla/5.0 (Linux; Android 9; RMX3551 Build/PQ3A.190705.003; wv) AppleWebKit/537.36 (KHTML, like Gecko) Version/4.0 Chrome/91.0.4472.114 Mobile Safari/537.36 (Mobile; afma-sdk-a-v231710999.204204000.1)");
            httpClient.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));
        }

        public async Task<string> GetServers()
        {
            var response = await httpClient.GetAsync($"{apiUrl}/get_servers.php");
            return await response.Content.ReadAsStringAsync();
        }
    }
}
