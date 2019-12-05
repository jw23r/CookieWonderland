using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tilt : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        TiltControler();
    }
    private void TiltControler()
    {
            Vector3 movement = new Vector3(-Input.GetAxis("Vertical"), 0, Input.GetAxis("Horizontal"));

            //transform.position += movement * speed;
            transform.Rotate(movement, Space.Self);

        }
    }

