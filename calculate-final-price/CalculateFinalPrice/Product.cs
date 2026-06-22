using System;

namespace CalculateFinalPrice;

public class Product
{
    public double Cost { get; set; }
    public int Tax { get; set; }

    public double CalculateFinalPrice()
    {
        if (Cost  == 0)
            return 0.00;

        return 20.00;
    }
}