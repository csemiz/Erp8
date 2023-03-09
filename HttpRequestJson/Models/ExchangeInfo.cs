namespace HttpRequestJson.Models;


public class ExChangeInfo
{
    public string TimeZone { get; set; }
    public long ServerTime { get; set; }
    public object[] RateLimits { get; set; }
    public object[] ExchangeFilters { get; set; }
    public List<SymbolInfo> Symbols { get; set; } = new List<SymbolInfo>();
}

