using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

//*** Controls the players movement and item pick up ***//
public class PlayerControls : MonoBehaviour
{
    [SerializeField] private float walkSpeed;
    [SerializeField] private SpriteRenderer sr;
    public int juice; // tracks if player grab item or not
    public TMP_Text list;
    public TMP_Text receipt;
    public TMP_Text finalCost;
    public static string shopList;
    public static int totalCost;
    [SerializeField] private Animator anim;

    // Start is called before the first frame update
    void Start()
    {
        //List of food the player has to find
        shopList = "Juice\nCoffee\nBroccoli\nAvocado\nCake\nPizza";
    }

    // Update is called once per frame
    void Update()
    {
        //*** Move Controls ***//
        Vector3 move = new Vector3(0,0,0);
        //Left
        if(Input.GetKey(KeyCode.A))
        {
            move.x = -walkSpeed;
            sr.GetComponent<SpriteRenderer>().flipX = true;
        }
        //Right
        if (Input.GetKey(KeyCode.D))
        {
            move.x = walkSpeed;
            sr.GetComponent<SpriteRenderer>().flipX = false;
        }
        //Up
        if (Input.GetKey(KeyCode.W))
        {
            move.y = walkSpeed;
        }
        //Down
        if (Input.GetKey(KeyCode.S))
        {
            move.y = -walkSpeed;
        }        
        transform.position += move * Time.deltaTime;

        Debug.Log("Walk speed: " +walkSpeed);
        if(Mathf.Abs(move.x) > 0 || Mathf.Abs(move.y) > 0)
        {
            anim.Play("walk");
        }
        else if(Input.GetMouseButtonDown(0) == true)
        {
            anim.Play("grab");
        }
        else if (Mathf.Abs(move.x) <= 0 || Mathf.Abs(move.y) <= 0)
        {
            anim.Play("idle");
        }

        //Shopping List tracker
        list.text = shopList;        
    }    
}

/*
 Notes:
 "Juice: " + juice + "\nEggs: " + eggs; 
 this is how you do a line break in code
 */
