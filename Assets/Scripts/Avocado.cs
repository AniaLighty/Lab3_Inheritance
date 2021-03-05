using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//*** This script inheritants from Food, and sets the name and price for the cheaper Avocado ***//
public class Avocado : Food
{
    public override void PickUp()
    {
        Food.totalCost += 2;
        AddCost();
        base.PickUp();
    }

    public override void AddCost()
    {
        itemName = "Avocado";
        price = "2";
        base.AddCost();
    }
}
