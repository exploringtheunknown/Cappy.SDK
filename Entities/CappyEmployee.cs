using Newtonsoft.Json;

namespace Cappy.SDK.Entities;

public class CappyEmployee : CappyBase
{
    [JsonProperty("employeeId")]
    public string EmployeeId { get; set; }
    
    [JsonProperty("identificationNumber")]
    public string IdentificationNumber { get; set; }
    
    [JsonProperty("status")]
    public string Status { get; set; }
}