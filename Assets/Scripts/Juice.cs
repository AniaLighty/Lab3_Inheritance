using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//*** This script inheritants from Food, and sets the name and price for the cheaper juice ***//
public class Juice : Food
{
    public override void PickUp()
    {        
        Food.totalCost += 5;        
        AddCost();
        base.PickUp();
    }

    public override void AddCost()
    {
        itemName = "Juice";
        price = "5";
        base.AddCost();        
    }
}
