using System;

namespace CalculateFinalPrice;

public class Product
{
    public double Cost { get; set; }
    public int Tax { get; set; }

    public double CalculateFinalPrice()
    {
        if (Tax == 0)
            return Cost;

        return (Cost + (Cost * Tax/100));
    }
}