using Newtonsoft.Json;

namespace Cappy.SDK.Entities;

public class CappyWithdrawalSettings : CappyBase
{
    [JsonProperty("maxWithdrawalAmountPerPayday")]
    public double MaxWithdrawalAmountPerPayday { get; set; }

    [JsonProperty("maxWithdrawalPercentPerPayday")]
    public int MaxWithdrawalPercentPerPayday { get; set; }

    [JsonProperty("maxCustomWithdrawalPercentPerPayday")]
    public int MaxCustomWithdrawalPercentPerPayday { get; set; }
}