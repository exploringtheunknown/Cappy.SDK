using Newtonsoft.Json;

namespace Cappy.SDK.Entities;

public class CappyOffCyclePayment : CappyBase
{
    [JsonProperty("rows", NullValueHandling = NullValueHandling.Ignore)]
    public List<CappyOffCyclePaymentRow> Rows { get; set; }
}