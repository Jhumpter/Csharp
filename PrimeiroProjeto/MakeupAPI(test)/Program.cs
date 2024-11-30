using System.Text.Json;
using MakeupAPI_test_.Models;
using MakeupAPI_test_.Filter;

using (HttpClient client = new HttpClient())
{
    try
    {
        string response = await client.GetStringAsync("https://makeup-api.herokuapp.com/api/v1/products.json");
        var products = JsonSerializer.Deserialize<List<Product>>(response!);
        LinqFilter.OrderByBrand(products!);
    }
    catch (Exception ex)
    {
        Console.WriteLine($"We have a problem ({ex.Message})");
    }
}