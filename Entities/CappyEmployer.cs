using Newtonsoft.Json;

namespace Cappy.SDK.Entities;

public class CappyEmployer : CappyBase
{
    [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
    public string Name { get; set; }

    [JsonProperty("bankAccountClearingNumber", NullValueHandling = NullValueHandling.Ignore)]
    public string BankAccountClearingNumber { get; set; }

    [JsonProperty("bankAccountNumber", NullValueHandling = NullValueHandling.Ignore)]
    public string BankAccountNumber { get; set; }

    [JsonProperty("defaultWithdrawalTaxInPercent", NullValueHandling = NullValueHandling.Ignore)]
    public int DefaultWithdrawalTaxInPercent { get; set; }

    [JsonProperty("launchDate", NullValueHandling = NullValueHandling.Ignore)]
    public DateTime LaunchDate { get; set; }
}