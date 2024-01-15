using Newtonsoft.Json;

namespace Cappy.SDK.Entities;

public class CappyDetailedEmployee : CappyBase
{
    [JsonProperty("id")]
    public string Id { get; set; }

    [JsonProperty("status")]
    public string Status { get; set; }

    [JsonProperty("type")]
    public string Type { get; set; }

    [JsonProperty("payCalculationType")]
    public string PayCalculationType { get; set; }

    [JsonProperty("givenName")]
    public string GivenName { get; set; }

    [JsonProperty("familyName")]
    public string FamilyName { get; set; }

    [JsonProperty("identificationNumber")]
    public string IdentificationNumber { get; set; }

    [JsonProperty("email")]
    public string Email { get; set; }

    [JsonProperty("phoneNumber")]
    public string PhoneNumber { get; set; }

    [JsonProperty("department")]
    public string Department { get; set; }

    [JsonProperty("category")]
    public string Category { get; set; }

    [JsonProperty("location")]
    public string Location { get; set; }

    [JsonProperty("costCenter")]
    public string CostCenter { get; set; }

    [JsonProperty("payScheduleIdentifier")]
    public string PayScheduleIdentifier { get; set; }

    [JsonProperty("startDate")]
    public string StartDate { get; set; }

    [JsonProperty("paused")]
    public bool Paused { get; set; }

    [JsonProperty("pauseReason")]
    public string PauseReason { get; set; }

    [JsonProperty("nonEligible")]
    public bool NonEligible { get; set; }

    [JsonProperty("underForeclosure")]
    public bool UnderForeclosure { get; set; }

    [JsonProperty("handleVacationPay")]
    public bool HandleVacationPay { get; set; }

    [JsonProperty("vacationPayPercent")]
    public double VacationPayPercent { get; set; }

    [JsonProperty("taxSettings")]
    public CappyTaxSettings TaxSettings { get; set; }

    [JsonProperty("withdrawalSettings")]
    public CappyWithdrawalSettings WithdrawalSettings { get; set; }
}