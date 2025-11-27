using DecoratorPattern;
using Microsoft.Extensions.DependencyInjection;


var services = new ServiceCollection();

services.AddScoped<ProductRepository>();
services.AddScoped<IProductRepository>(serviceProvider =>
{
    var realRepository = serviceProvider.GetRequiredService<ProductRepository>();
    return new CachedProductRepository(realRepository);
});

var serviceProvider = services.BuildServiceProvider();

IProductRepository repository = serviceProvider.GetRequiredService<IProductRepository>();


Console.WriteLine("\n--- 1. GetById(101) ---");
repository.GetById(101);

Console.WriteLine("\n--- 2. GetById(102) ---");
repository.GetById(102);

Console.WriteLine("\n--- 3. GetById(103) ---");
repository.GetById(103);

Console.ReadLine();