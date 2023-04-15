using System.Net.Http.Json;
using StockApp.Models;

namespace StockApp.Clients;
public class StockClient{

    private readonly HttpClient _client;
    
    //constructor
    public StockClient(HttpClient Client){
        _client = Client;
        _client.DefaultRequestHeaders.Add("X-RapidAPI-Key", "95db00eceemsh61c801a764f1abdp10a587jsn0dfc17c1761a");
    }

    

    public async Task<StockResponse> GetStock(string stockAcr){

        string url = "https://twelve-data1.p.rapidapi.com/stocks?exchange=NASDAQ&format=json" + "&symbol=AACG";
        if(stockAcr != null){
            url = "https://twelve-data1.p.rapidapi.com/stocks?exchange=NASDAQ&format=json" + "&symbol=" + stockAcr;
        }        
        return await _client.GetFromJsonAsync<StockResponse>(url);
    }

}