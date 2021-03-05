using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//*** This script inheritants from Food, and sets the name and price for the cheaper cake ***//
public class Cake : Food
{
    public override void PickUp()
    {
        Food.totalCost += 4;
        AddCost();
        base.PickUp();
    }

    public override void AddCost()
    {
        itemName = "Cake";
        price = "4";
        base.AddCost();
    }
}
