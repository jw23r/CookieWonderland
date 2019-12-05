using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimerDisplay : MonoBehaviour
{
    //look on main camera
    public GameController controller;
    Text text;

    void Start()
    {
        text = GetComponent<Text>();
    }


    void Update()
    {
        text.text = "Timer: " + (int)controller.timer;
    }
}
