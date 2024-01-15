    using Newtonsoft.Json;

    namespace Cappy.SDK.Entities;

public class CappyTaxSettings : CappyBase
{
    [JsonProperty("taxTableIdentifier")]
    public string TaxTableIdentifier { get; set; }

    [JsonProperty("withdrawalTaxInPercent")]
    public int WithdrawalTaxInPercent { get; set; }
}