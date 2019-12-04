using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Press : MonoBehaviour
{
     Vector3 startPos;
    Vector3 pressed;
    // Start is called before the first frame update
    void Start()
    {
        startPos = gameObject.transform.position;
        pressed = new Vector3(112.5f, 5.15f, 68.9f);
    }

    // Update is called once per frame
    void Update()
    {
        print(gameObject.transform.position);
       
        if (Input.GetKeyDown("space"))
        {

            gameObject.transform.position = pressed;   

     print("space key was pressed");
            print(gameObject.transform.position);
        }
        if (Input.GetKeyUp("space"))
        {

            gameObject.transform.position = startPos;

           ;
        }
    }
}
