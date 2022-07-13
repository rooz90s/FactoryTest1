// See https://aka.ms/new-console-template for more information

using FactoryTest1;

var CreditCardPlatinium = new PlatiniumFactory().CreateProduct();

Console.WriteLine($"{CreditCardPlatinium.GetCardType()} Credit Card includes {CreditCardPlatinium.GetAnnualCharge()} $ limit and {CreditCardPlatinium.GetAnnualCharge()} for annual charges ");


var creditCardMoneyBack = new MoneyBackFactory().CreateProduct();

Console.WriteLine($"{creditCardMoneyBack.GetCardType()} Credit Card includes {creditCardMoneyBack.GetAnnualCharge()} $ limit and {creditCardMoneyBack.GetAnnualCharge()} for annual charges ");




Console.WriteLine("Hello, World!");
