using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class heartbeat : MonoBehaviour
{
   [Range(0,1)]
   public float t;
   public float reverse;

    public bool checkmouseclick;
    public AnimationCurve pulse;

    // Start is called before the first frame update
    void Start()
    {
        checkmouseclick = false; 
        t = 0.1f;
        reverse = 0.3f;
    }

    // Update is called once per frame
    void Update()
    {
        if(t>=1 || t <= 0){
        reverse *= -1;
        }
       if(Input.GetMouseButtonDown(0))
       {
           checkmouseclick = true; 
          
       }
      if(checkmouseclick == true){

      t += reverse * Time.deltaTime; 

      transform.localScale = Vector2.one * pulse.Evaluate(t);
      }
        
    }
}
