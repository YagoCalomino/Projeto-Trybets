using System.Net.Http;
namespace TryBets.Bets.Services;

public class OddService : IOddService
{
    private readonly HttpClient _client;
    public OddService(HttpClient client)
    {
        _client = client;
    }

    public async Task<object> UpdateOdd(int MatchId, int TeamId, decimal BetValue)
    {
         var res = await _client.PatchAsync($"http://localhost:5504/Odd/{MatchId}/{TeamId}/{BetValue}", null);

         res.EnsureSuccessStatusCode();
         var result = await res.Content.ReadAsStringAsync();

         return result;    
    }
}