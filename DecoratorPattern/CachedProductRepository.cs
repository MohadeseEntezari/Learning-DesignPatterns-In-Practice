namespace DecoratorPattern;

internal class CachedProductRepository : IProductRepository
{
    private readonly IProductRepository _productRepository;

    public CachedProductRepository(IProductRepository productRepository)
    {
        _productRepository = productRepository;
    }

    public Product GetById(int id)
    {
        if (id % 2 != 0)
        {
            Console.WriteLine($"[CACHE MISS] Product {id} was NOT found in the Cache.");
            
            Product product = _productRepository.GetById(id);

            Console.WriteLine($"[CACHE SET] Product {id} is now being stored in the Cache for next time.");
            return product;
        }
        else
        {
            Console.WriteLine($"[CACHE HIT] Product {id} was successfully retrieved from the **Cache**.");
            return new Product { Id = id, Name = $"Product {id}" };
        }
    }
}