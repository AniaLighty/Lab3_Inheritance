using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//*** This script inheritants from Food, and sets the name and price for the cheaper coffee ***//
public class Coffee : Food
{
    public override void PickUp()
    {
        Food.totalCost += 3;
        AddCost();
        base.PickUp();
    }

    public override void AddCost()
    {
        itemName = "Coffee";
        price = "3";
        base.AddCost();
    }
}
