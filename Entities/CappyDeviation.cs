using Newtonsoft.Json;

namespace Cappy.SDK.Entities;

public class CappyDeviation : CappyBase
{
    [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
    public string Id { get; set; }
    
    [JsonProperty("employeeId", NullValueHandling = NullValueHandling.Ignore)]
    public string EmployeeId { get; set; }

    [JsonProperty("date", NullValueHandling = NullValueHandling.Ignore)]
    public string Date { get; set; }

    [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
    public string Description { get; set; }

    [JsonProperty("amount", NullValueHandling = NullValueHandling.Ignore)]
    public int Amount { get; set; }
}