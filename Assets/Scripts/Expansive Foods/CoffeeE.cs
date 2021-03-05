using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//*** This script inheritants from Food, and sets the name and price for the expansive coffee ***//
public class CoffeeE : Food
{
    // Start is called before the first frame update
    public override void PickUp()
    {
        Food.totalCost += 7;
        AddCost();
        base.PickUp();
    }

    public override void AddCost()
    {
        itemName = "Coffee";
        price = "7";
        base.AddCost();
    }
}
