using System.Text.Json.Serialization;

namespace MakeupAPI_test_.Models;

internal class Product
{
    [JsonPropertyName("brand")]
    public string? Brand { get; set; }
    [JsonPropertyName("name")]
    public string? Name { get; set; }
    [JsonPropertyName("price")]
    public string? Price { get; set; }
    [JsonPropertyName("category")]
    public string? Category { get; set; }
}
