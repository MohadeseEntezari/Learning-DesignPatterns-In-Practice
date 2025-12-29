// See https://aka.ms/new-console-template for more information
using StatePattern;

var order = new OrderContext(new CreatedState());

order.Pay();
order.Pay(); 

