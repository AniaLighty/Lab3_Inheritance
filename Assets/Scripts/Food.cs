using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

//*** Base class for all "food" objects in the game to inheritate from ***//
public class Food : MonoBehaviour
{
    public string itemName;    
    public static int totalCost;
    public static string itemCost;
    public static string price; //<- cost of each specific "food" item
    private SpriteRenderer sr;

    // Start is called before the first frame update
    void Start()
    {
        itemCost = "";
        price = "test";
        itemName = "test";
        sr = GetComponent<SpriteRenderer>();
    }

    //Tells food items what to do when clicked on
    public virtual void PickUp()
    {       
        PlayerControls.shopList = PlayerControls.shopList.Replace(itemName, "<s>"+itemName+"</s>"); //<- crossed out food on shopping list   
        Destroy(gameObject);
    }

    //Displays food item and its cost in the end scene
    public virtual void AddCost()
    {
        if (itemCost.Equals(""))
        {            
            itemCost += itemName+": "+price;
        }
        else
        {            
            itemCost += "\n" + itemName + ": " + price;
        }
        itemCost += "";
        
    }

    //Change ahpla of food items' when hovered overed
    public void OnMouseEnter()
    {
        Color c = sr.color;
        c.a = .70f;
        sr.color = c;
    }

    //Resets food items' ahpla to soild
    public void OnMouseExit()
    {
        Color c = sr.color;
        c.a = 1f;
        sr.color = c;
    }

    //Triggers PickUp fucntion
    public void OnMouseDown()
    {        
        PickUp();
    }
}
/*Notes:
 * <s>Juice</s> this allows me to do a strike though in game
 * PlayerControls.shopList.Replace("juice", "<s>Juice</s>"); <<- this looks and my shoping list for the word jice and replaces the word juic
 * with the strike through juice
*/
