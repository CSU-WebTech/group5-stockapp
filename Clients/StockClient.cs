using System.Net.Http.Json;
using StockApp.Models;

namespace StockApp.Clients;
public class StockClient{

    private readonly HttpClient _client;
    
    //constructor
    public StockClient(HttpClient client){
        _client = client;
        _client.DefaultRequestHeaders.Add("X-RapidAPI-Key", "95db00eceemsh61c801a764f1abdp10a587jsn0dfc17c1761a");
    }

    public async Task<StockResponse> GetStock(){
        return await _client.GetFromJsonAsync<StockResponse>("https://twelve-data1.p.rapidapi.com/stocks?exchange=NASDAQ&symbol=AACG&format=json");
    }

}