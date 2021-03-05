using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//*** This script inheritants from Food, and sets the name and price for the expansive pizza ***//
public class PizzaE : Food
{
    public override void PickUp()
    {
        Food.totalCost += 12;
        AddCost();
        base.PickUp();
    }

    public override void AddCost()
    {
        itemName = "Pizza";
        price = "12";
        base.AddCost();
    }
}
