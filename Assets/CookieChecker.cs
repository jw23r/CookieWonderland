using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CookieChecker : MonoBehaviour
{
    public GameController controller;
    void OnTriggerEnter(Collider collider)
    {
        if (collider.transform.tag == "Samoa")
        {
            //print("hit the right one!!");
        controller.Score(10 - collider.transform.localScale.x);
        }
        else
        {
            controller.TimePenalty();
            //print("Hit the wrong one");
        }
    }
}
