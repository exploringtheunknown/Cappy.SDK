using Newtonsoft.Json;

namespace Cappy.SDK.Entities;

public class CappyDeviationSynchronization : CappyBase
{
    [JsonProperty("syncWindowStart", NullValueHandling = NullValueHandling.Ignore)]
    public DateTime SyncWindowStart { get; set; }

    [JsonProperty("syncWindowEnd", NullValueHandling = NullValueHandling.Ignore)]
    public DateTime SyncWindowEnd { get; set; }

    [JsonProperty("payDeviations", NullValueHandling = NullValueHandling.Ignore)]
    public List<CappyDeviation> PayDeviations { get; set; }
}