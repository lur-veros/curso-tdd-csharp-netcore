
using System.Collections.Generic;
using NUnit.Framework;

namespace ArgentRose.Tests
{

    //Behaviour
    // update stock
    //Input:
    // inventario [producto {sellin, quality, description}]
    //output:
    //inventario [producto {sellin, quality, description}]
    //smallbehaviour
    //sellin decrease by 1
    //quality increase by 1 when sellin (6, inf)
    //quality increase by 3 when sellin [1, 6]
    //quality equals 0 when sellin <= 0
    //quality is never more than 50
    //quality is never less than 0

    //partitions
    //sellin   -inf -----0|1---6|7----inf  
    //quality (when sellin increase 1)   0-------49|50
    //quality (when sellin increase 3)   0-------47|48

    //ejemplos

    //Zero
    //[{}] --> [{}]

    //One
    // [{sellin: 0, quality: 10, description: "Theatre Passes"}] -> [{sellin: -1, quality: 0, description: "Theatre Passes"}]
    // [{sellin: 1, quality: 5, description: "Theatre Passes"}] -> [{sellin: 0, quality: 8, description: "Theatre Passes"}]
    // [{sellin: 6, quality: 4, description: "Theatre Passes"}] -> [{sellin: 5, quality: 7, description: "Theatre Passes"}]
    // [{sellin: 7, quality: 3, description: "Theatre Passes"}] -> [{sellin: 6, quality: 4, description: "Theatre Passes"}]
    // Invariante
    // [{sellin: 10, quality: 49, description: "Theatre Passes"}] -> [{sellin: 9, quality: 50, description: "Theatre Passes"}]
    // [{sellin: 10, quality: 50, description: "Theatre Passes"}] -> [{sellin: 9, quality: 50, description: "Theatre Passes"}]
    // [{sellin: 5, quality: 47, description: "Theatre Passes"}] -> [{sellin: 4, quality: 50, description: "Theatre Passes"}]
    // [{sellin: 5, quality: 48, description: "Theatre Passes"}] -> [{sellin: 4, quality: 50, description: "Theatre Passes"}]

    //Many
    // [{sellin: 0, quality: 10, description: "Theatre Passes"}, {sellin: 1, quality: 5, description: "Theatre Passes"}]
    // -> [{sellin: -1, quality: 0, description: "Theatre Passes"}, {sellin: 0, quality: 8, description: "Theatre Passes"}]

    public class ArgentRoseTest
    {
        [Test]
        public void When_EmptyInventory_Then_Return_EmptyInventory()
        {
            Inventory inventory = new Inventory(new List<Product>());

            List<Product> updatedInventory = inventory.Update();

            Assert.That(updatedInventory, Is.Empty);
        }

        //[Test]
        //public void When_Inventory_HasOneProduct_And_Sellin_Is_Higher_Than6_Returns_QualityIncrease1()
        //{
        //    // [{sellin: 7, quality: 3, description: "Theatre Passes"}] 
        //    //-> [{sellin: 6, quality: 4, description: "Theatre Passes"}]

        //    Inventory inventory = new Inventory();

        //    List<Product> updatedInventory = inventory.Update(new List<Product>());

        //    Assert.That(updatedInventory, Is.Empty);
        //}
    }
}
