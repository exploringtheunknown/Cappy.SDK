using Newtonsoft.Json;

namespace Cappy.SDK.Entities;

public class CappyFile : CappyBase
{
    [JsonProperty("file", NullValueHandling = NullValueHandling.Ignore)]
    public string File { get; set; }
}