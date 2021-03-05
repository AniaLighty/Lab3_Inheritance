using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//*** This script inheritants from Food, and sets the name and price for the expansive broccoli ***//
public class BroccoliE : Food
{
    public override void PickUp()
    {
        Food.totalCost += 10;
        AddCost();
        base.PickUp();
    }

    public override void AddCost()
    {
        itemName = "Broccoli";
        price = "10";
        base.AddCost();
    }
}
