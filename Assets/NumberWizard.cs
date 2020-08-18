using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWizard : MonoBehaviour
{
        int max  = 1000;
        int min  = 1;
        int guess = 500;

    // Start is called before the first frame update
    void Start()
    {
       

        Debug.Log("Welcome to number wizard");
        Debug.Log("Pick a number");
        Debug.Log("Highest Number is: "+max);
        Debug.Log("Lowest Number is: "+min);
        Debug.Log("Tell  if your number is higher or lower than 500");
        Debug.Log("Push UP = Higher, Push Down = Lower, Push Enter = Correct");
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.UpArrow)){
            
            min = guess;
            Debug.Log(guess);
            guess = (min+max)/2;
            Debug.Log(guess);


            // Debug.Log("UP arrow Pressed");
        }else if(Input.GetKeyDown(KeyCode.DownArrow)){
            
            max = guess;

            Debug.Log(guess);
            guess = (max+min)/2;
            Debug.Log(guess);
            // Debug.Log("Down Arrow Pressed");
        }else if(Input.GetKeyDown(KeyCode.Return)){

            // Debug.Log("Enter Key Pressed");
        }

    }
}
