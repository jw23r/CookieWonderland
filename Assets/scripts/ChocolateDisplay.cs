using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChocolateDisplay : MonoBehaviour
{
    //look on main camera
    public GameController controller;

    void Start()
    {
    }


    void Update()
    {
        Vector3 scale = new Vector3(1, controller.chocolate / controller.chocolateMax ,1);

        transform.localScale = scale;
    }
}
