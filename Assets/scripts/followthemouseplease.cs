 using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class followthemouseplease : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 mousPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        //Camera.main.ScreenToWorldPoint(Input.mousePosition);
        transform.position = mousPos;

    }
}
