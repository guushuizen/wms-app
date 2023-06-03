using System.Text.Json.Serialization;

namespace LyraWMS.Models;

public class Product
{
    public int Id { get; set; }
    public string Uuid { get; set; }
    public string Sku { get; set; }
    public string Name { get; set; }
    public string Barcode { get; set; }
    public int Price { get; set; }
    public int Vat { get; set; }
    public int Stock { get; set; }

    [JsonNumberHandling(JsonNumberHandling.AllowReadingFromString)]
    public int TotalStock { get; set; }
    public int ReservedStock { get; set; }
    public int KeepStockAsBuffer { get; set; }
    public string Type { get; set; }
    public bool Active { get; set; }
    public object DeletedAt { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }
    [JsonPropertyName("fulfilmentclient.name")]
    public string FulfilmentClientName { get; set; }
    public Pivot Pivot { get; set; }
    public List<ProductLocation> ProductLocations { get; set; }
}