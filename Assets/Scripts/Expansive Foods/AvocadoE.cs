using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//*** This script inheritants from Food, and sets the name and price for the expansive avocado ***//
public class AvocadoE : Food
{
    public override void PickUp()
    {
        Food.totalCost += 6;
        AddCost();
        base.PickUp();
    }

    public override void AddCost()
    {
        itemName = "Avocado";
        price = "6";
        base.AddCost();
    }
}
