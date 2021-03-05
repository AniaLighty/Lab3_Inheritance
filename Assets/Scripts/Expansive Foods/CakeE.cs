using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//*** This script inheritants from Food, and sets the name and price for the expansive cake ***//
public class CakeE : Food
{
    public override void PickUp()
    {
        Food.totalCost += 10;
        AddCost();
        base.PickUp();
    }

    public override void AddCost()
    {
        itemName = "Cake";
        price = "10";
        base.AddCost();
    }
}
