using NUnit.Framework;

namespace CalculateFinalPrice.Tests;

public class CalculateFinalPriceTest
{ 
    [Test]
    public void When_NoTax_Then_FinalPrice_Equals_Cost()
    {
        Product product = new Product
        {
            Cost = 20.00,
            Tax = 0
        };

        double finalPrice = product.CalculateFinalPrice();

        Assert.That(finalPrice, Is.EqualTo(20.00).Within(0.0001));
    }

    //[] product(cost:0.00eur, tax:0%) => finalPrice:0.00eur

    [Test]
    public void When_NoCost_Then_FinalPrice_Equals_Zero()
    {
        Product product = new Product
        {
            Cost = 0.00,
            Tax = 0
        };

        double finalPrice = product.CalculateFinalPrice();

        Assert.That(finalPrice, Is.EqualTo(0.00).Within(0.0001));
    }
}