using System.Text.Json.Serialization;

namespace WMS.Models;

public class FulfilmentClient
{
    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("name")]
    public string Name { get; set; }

    [JsonPropertyName("uuid")]
    public string Uuid { get; set; }
}
