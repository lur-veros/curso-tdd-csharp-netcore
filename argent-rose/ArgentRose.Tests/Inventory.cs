using System;
using System.Collections.Generic;

namespace ArgentRose.Tests;

internal class Inventory
{
    private List<Product> products;

    public Inventory(List<Product> products)
    {
        this.products = products;
    }

    internal List<Product> Update()
    {
        return products;
    }
}