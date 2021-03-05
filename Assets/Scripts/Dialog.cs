using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

//*** Controls introduction text. ***//

public class Dialog : MonoBehaviour
{
    [SerializeField] private string[] introText;
    [SerializeField] private int index;
    [SerializeField] private TextMeshProUGUI dialog;
    
    
    [SerializeField] private GameObject startGame; // <- button for Gameplay scene

    // Start is called before the first frame update
    void Start()
    {
        dialog.text = introText[index];
    }


    //Runs intro dialog
    public void ChangeText()
    {        
       dialog.text = introText[index];
       if (index < introText.Length - 1)
       {
           index++;
       }           
        
        if (index == 5)
        {            
            startGame.SetActive(true);
        }
    }

   
}
