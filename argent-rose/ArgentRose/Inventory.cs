using System.Collections.Generic;

namespace ArgentRose.Tests;

public class Inventory
{
    private List<Product> products;

    public Inventory(List<Product> products)
    {
        this.products = products;
    }

    public List<Product> Update()
    {
        return products;
    }
}