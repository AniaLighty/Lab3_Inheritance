using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//*** This script inheritants from Food, and sets the name and price for the cheaper broccoli ***//
public class Broccoli : Food
{
    public override void PickUp()
    {
        Food.totalCost += 6;
        AddCost();
        base.PickUp();
    }

    public override void AddCost()
    {
        itemName = "Broccoli";
        price = "6";
        base.AddCost();
    }
}
