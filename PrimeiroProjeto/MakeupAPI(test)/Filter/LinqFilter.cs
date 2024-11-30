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
    public static void OrderByName(List<Product> products)
    {
        var names = products.Select(product => product.Name).Distinct().ToList();
        names.Sort();
        foreach (var name in names)
        {
            Console.WriteLine(name);
        }
    }
    public static void OrderByCategory(List<Product> products)
    {
        var categories = products.Select(product => product.Category).Distinct().ToList();
        categories.Sort();
        foreach (var category in categories)
        {
            Console.WriteLine(category);
        }
    }

}
