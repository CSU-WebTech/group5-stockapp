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

        string url = "https://twelve-data1.p.rapidapi.com/time_series?interval=1day" + "&symbol=AACG";
        
        if(stockAcr != null){
            url = "https://twelve-data1.p.rapidapi.com/time_series?interval=1day" + "&symbol=" + stockAcr;
        }        
        return await _client.GetFromJsonAsync<StockResponse>(url);
    }

    public async Task<StockResponseWatchList> GetAllStocks(string stockAcr){

        string url = "https://twelve-data1.p.rapidapi.com/stocks" + "?symbol=AACG";
        if(stockAcr != null){
            url = "https://twelve-data1.p.rapidapi.com/stocks" + "?symbol=" + stockAcr;
        }        
        return await _client.GetFromJsonAsync<StockResponseWatchList>(url);
    }

    public async Task<StockResponseWatchList> GetStockCode(string stockCode){

        string url = "https://twelve-data1.p.rapidapi.com/stocks" + "?mic_code=XNMS";
        if(stockCode != null){
            url = "https://twelve-data1.p.rapidapi.com/stocks" + "?mic_code=" + stockCode;
        }        
        return await _client.GetFromJsonAsync<StockResponseWatchList>(url);
    }    
    
    public async Task<StockResponseWatchList> GetCurrency(string theCurr){

        string url = "https://twelve-data1.p.rapidapi.com/stocks" + "?currency=USD";
        if(theCurr != null){
            url = "https://twelve-data1.p.rapidapi.com/stocks" + "?currency=" + theCurr;
        }        
        return await _client.GetFromJsonAsync<StockResponseWatchList>(url);
    }         

    public async Task<StockResponseWatchList> GetExchange(string theExch){

        string url = "https://twelve-data1.p.rapidapi.com/stocks" + "?exchange=NASDAQ";
        if(theExch != null){
            url = "https://twelve-data1.p.rapidapi.com/stocks" + "?exchange=" + theExch;
        }        
        return await _client.GetFromJsonAsync<StockResponseWatchList>(url);
    }  
}