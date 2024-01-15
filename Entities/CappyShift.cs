using Newtonsoft.Json;

namespace Cappy.SDK.Entities;

public class CappyShift : CappyBase
{
    [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
    public string Id { get; set; }
    
    [JsonProperty("employeeId", NullValueHandling = NullValueHandling.Ignore)]
    public string EmployeeId { get; set; }

    [JsonProperty("date", NullValueHandling = NullValueHandling.Ignore)]
    public string Date { get; set; }

    [JsonProperty("hours", NullValueHandling = NullValueHandling.Ignore)]
    public int Hours { get; set; }

    [JsonProperty("wages", NullValueHandling = NullValueHandling.Ignore)]
    public int Wages { get; set; }

    [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
    public string Type { get; set; }

    [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
    public string Status { get; set; }

    [JsonProperty("start", NullValueHandling = NullValueHandling.Ignore)]
    public DateTime Start { get; set; }

    [JsonProperty("end", NullValueHandling = NullValueHandling.Ignore)]
    public DateTime End { get; set; }

    [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
    public string Description { get; set; }

    [JsonProperty("location", NullValueHandling = NullValueHandling.Ignore)]
    public string Location { get; set; }
}