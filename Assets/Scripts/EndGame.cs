using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

//*** Shows the Players final score cost in the game ***//
public class EndGame : Food
{
    public TMP_Text receipt;
    public TMP_Text finalCost;

    // Start is called before the first frame update
    void Start()
    {
        receipt.text = Food.itemCost;
        CashOut();
        //finalCost.text = "Total Cost: " + Food.totalCost;
    }    

    //Shows player's final score in the end scene
    public void CashOut()
    {
        //On Budget
        if (totalCost <= 20)
        {
            finalCost.text = "Total Cost: " + totalCost + "\n(You stayed on budget!)";
        }
        //Little over budget
        else if (totalCost > 20 && totalCost < 35)
        {
            finalCost.text = "Total Cost: " + totalCost + "\n(Over budget! Put something back.)";
        }
        //Very over budget
        else
        {
            finalCost.text = "Total Cost: " + totalCost + "\n(What did you buy? You only have 20 to spend.)";
        }
    }
}
