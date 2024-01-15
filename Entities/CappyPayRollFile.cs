using Newtonsoft.Json;

namespace Cappy.SDK.Entities;

public class CappyPayRollFile : CappyBase
{
    [JsonProperty("fileId", NullValueHandling = NullValueHandling.Ignore)]
    public string FileId { get; set; }

    [JsonProperty("payday", NullValueHandling = NullValueHandling.Ignore)]
    public string Payday { get; set; }

    [JsonProperty("rows", NullValueHandling = NullValueHandling.Ignore)]
    public List<CappyPayRollFileRow> Rows { get; set; }
}