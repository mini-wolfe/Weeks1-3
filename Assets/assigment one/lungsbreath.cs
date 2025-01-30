using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lungsbreath : MonoBehaviour
{
    //adding in variables 
    //adding range 
   [Range(0,1)]
   //creating public varible , to track lerping movment up and down 
   public float t;
   // adding in varibale to tell the compenent when to reverse and what rate 
   public float reverse;
   // adding start and end positions to tell th lungs where to lerp from and to 
   public Transform start;
   public Transform end;

    // Start is called before the first frame update
    void Start()
    {
        //assigning values to the lerp tracking and reverse rate
       t=0.1f; 
       reverse = 0.3f;
    }

    // Update is called once per frame
    void Update()
    {
        // telling the lungs that when t is greater then or equal to 1 or less then or equal to 0 reveres is a negative  
       if(t>=1 || t <= 0){
        reverse *= -1;
        }
        
        t += reverse * Time.deltaTime; 
        // telling the lungs that they have a start and end position that i assign them that they will lerp to and from 
        transform.position = Vector2.Lerp(start.position,end.position,t);
    
    }
}
