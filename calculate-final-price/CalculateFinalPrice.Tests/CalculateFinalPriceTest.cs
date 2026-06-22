using NUnit.Framework;

namespace CalculateFinalPrice.Tests;

public class CalculateFinalPriceTest
{ 
    [TestCase(20.00, 0)]
    [TestCase(0.00, 0)]
    [TestCase(1.89, 0)]
    public void When_NoTax_Then_FinalPrice_Equals_Cost(double cost, int tax)
    {
        Product product = new Product
        {
            Cost = cost,
            Tax = tax
        };

        double finalPrice = product.CalculateFinalPrice();

        Assert.That(finalPrice, Is.EqualTo(cost).Within(0.0001));
    }
}