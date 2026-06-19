### Calculating final price per unit of a product.

> As a seller I'd like to compute the final price of a product including taxes 
> in order to show it to my customers.

1. Products have a cost per unit and tax percentage to apply. 
2. The cost per unit is in euros.
4. The final price has to be rounded up. For instance, if the calculated final price
of a product is 1.7825€, the expected final price for that product is 1.79€.
5. The final price of the product is then calculated as the cost per unit with the taxes rounded up.
6. All the prices are in euros.


### Exercise
Observable Behavior:

Calculate finalPrice

Input: product(cost, tax)
Output: finalPrice

Smaller Behaviors:
* Apply taxes: cost + (cost * tax / 100)
* Rounded

Examples:
[] product(cost:100.00eur, tax:50%) => finalPrice:150.00eur
[] product(cost:0.00eur, tax:0%) => finalPrice:0.00eur
[] product(cost:0.00eur, tax:10%) => finalPrice:0.00eur
[] product(cost:20.00eur, tax:0%) => finalPrice:20.00eur
[] product(cost:1.89eur, tax:0%) => finalPrice:1.89eur
[] product(cost:23.47eur, tax:21%) => finalPrice:28.40eur