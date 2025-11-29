using FactoryPattern;
using Microsoft.Extensions.DependencyInjection;

var services = new ServiceCollection();

services.AddScoped<IPaymentGateway,MellatGateway>();
services.AddScoped<IPaymentGateway,ZarinpalGateway>();

ShoppingCart cart = new ShoppingCart();

cart.Checkout(150.00m, "zarin");

cart.Checkout(25.50m, "mellat");
