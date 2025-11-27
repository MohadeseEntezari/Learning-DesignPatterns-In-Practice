namespace DecoratorPattern;

internal class ProductRepository : IProductRepository
{
    public Product GetById(int id)
    {
        Console.WriteLine($"[DB ACCESS] --> Product {id} is being fetched from the **Database**.");
        return new Product { Id = id, Name = $"Product {id}" };
    }
}
