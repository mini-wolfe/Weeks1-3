using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class heartbeat : MonoBehaviour
{
    public bool checkmouseclick;

    // Start is called before the first frame update
    void Start()
    {
        checkmouseclick = false; 
    }

    // Update is called once per frame
    void Update()
    {
       if(Input.GetMouseButtonDown(0))
       {
           checkmouseclick = true; 
          
       }
      if(checkmouseclick == true){
           Debug.Log("Hi");
      }
        
    }
}
