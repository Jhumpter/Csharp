using MakeupAPI_test_.Models;

namespace MakeupAPI_test_.Filter;

internal class LinqProducts
{
    public static void OrderProductsByBrand(List<Product> products, string brand)
    {
        var productsByBrand = products.Where(products => products.Brand! == brand).ToList();
        foreach(var product in productsByBrand)
        {
            Console.WriteLine(product.Name);
        }
    }

    public static void OrderProductsByCategory(List<Product> products, string category)
    {
        var productsByCategory = products.Where(products => products.Category! == category).ToList();
        foreach (var product in productsByCategory)
        {
            Console.WriteLine(product.Name);
        }
    }
}