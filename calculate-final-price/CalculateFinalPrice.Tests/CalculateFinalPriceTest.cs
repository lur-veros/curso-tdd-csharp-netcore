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
    
    [Test]
    public void When_Tax_Greater_Than_Zero_Apply_Tax_To_Cost()
    {
        Product product = new Product
        {
            Cost = 0.00,
            Tax = 10
        };

        double finalPrice = product.CalculateFinalPrice();

        Assert.That(finalPrice, Is.EqualTo(0.00).Within(0.0001));
    }


    [Test]
    public void When_Tax_Greater_Than_Zero_Apply_Tax_To_Cost_2()
    {
        Product product = new Product
        {
            Cost = 100.00,
            Tax = 50
        };
        double finalPrice = product.CalculateFinalPrice();
        Assert.That(finalPrice, Is.EqualTo(150.00).Within(0.0001));
    }
}