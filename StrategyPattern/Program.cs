using StrategyPattern;

ShoppingCart cart = new ShoppingCart();
double orderTotal = 500000;

// 1. Choosing the "Banking Gateway" strategy
Console.WriteLine("--- Select method: Banking portal ---");
IPaymentStrategy samamBank = new BankGatewayPayment();
cart.SetPaymentStrategy(samamBank);
cart.Checkout(orderTotal);

// 2. Change the strategy at runtime to "wallet"
Console.WriteLine("\n--- Changing method to: Wallet ---"); 
IPaymentStrategy myWallet = new WalletPayment(800000); 
cart.SetPaymentStrategy(myWallet);
cart.Checkout(orderTotal);

// 3. Attempt to pay again (this time the wallet balance is not enough!)
Console.WriteLine("\n--- Repurchase with empty wallet ---"); 
cart.Checkout(400000); 