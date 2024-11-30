using MakeupAPI_test_.Models;

namespace MakeupAPI_test_.Filter;

internal class LinqFilter
{
    public static void OrderByBrand(List<Product> products)
    {
        var brands = products.Select(product => product.Brand).Distinct().ToList();
        brands.Sort();
        foreach (var brand in brands)
        {
            Console.WriteLine(brand);
        }
    }
}
