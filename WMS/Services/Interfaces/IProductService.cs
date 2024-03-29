using System.Net;
using System.Text.Json;
using System.Text.Json.Nodes;
using WMS.Models;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Location = WMS.Models.Location;

namespace WMS.Services.Interfaces;

public interface IProductService
{
    public Task<List<Product>> GetProducts(int page = 0);

    public Task<Product?> FindProduct(string sku);

    public Task<List<Location>> GetAvailableLocations(Product product, Warehouse warehouse);

    public Task<List<Warehouse>> GetWarehouses();

    public Task<bool> MoveStock(
        Product product,
        int amount,
        Location newLocation,
        ProductLocation oldProductLocation
    );
}
