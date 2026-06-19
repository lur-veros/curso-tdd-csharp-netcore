using System;

namespace CalculateFinalPrice;

public class Product
{
    public double Cost { get; set; }
    public int Tax { get; set; }

    public double CalculateFinalPrice()
    {
        return 20.00;
    }
}