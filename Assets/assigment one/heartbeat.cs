using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class heartbeat : MonoBehaviour
//declare range 
{
//adding in t value for the pace aat which the heart will beat
   [Range(0,1)] 
   float t;
   //telling the heart to return to the orignal postion. 
   public float reverse;
   // public boulean for when mousse is click 
    public bool checkmouseclick;
    //adding in an animation curve for the heart beat lerping 
    public AnimationCurve pulse;

    // Start is called before the first frame update
    void Start()
    {
        //declaring mouse clicked is false until mouse is pressed 
        checkmouseclick = false; 
        //tracking pace of shriking 
        t = 0.1f;
        //reverse the heart rate so it doesnt go invisable 
        reverse = 0.3f;
    }

    // Update is called once per frame
    void Update()
    {
        //if statment for when the mouse button is reversed 
        if(t>=1 || t <= 0){
        reverse *= -1;
        }
        //if statment for when mouse , left mouse button is clicked making the boolean true 
       if(Input.GetMouseButtonDown(0))
       {
           checkmouseclick = true;   
       }
       // fucntion for when mouse is down have the heart pulse base on the animation curve 
      if(checkmouseclick == true)
      {

      t += reverse * Time.deltaTime; 

      transform.localScale = Vector2.one * pulse.Evaluate(t);
      }
    }          
}
