using Newtonsoft.Json;

namespace Cappy.SDK.Entities;

public class CappyShiftSynchronization : CappyBase
{
    [JsonProperty("syncWindowStart", NullValueHandling = NullValueHandling.Ignore)]
    public DateTime SyncWindowStart { get; set; }

    [JsonProperty("syncWindowEnd", NullValueHandling = NullValueHandling.Ignore)]
    public DateTime SyncWindowEnd { get; set; }

    [JsonProperty("shifts", NullValueHandling = NullValueHandling.Ignore)]
    public List<CappyShift> Shifts { get; set; }
}