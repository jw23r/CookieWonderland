using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreDisplay : MonoBehaviour
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
        text.text = "Score: " + controller.score;
    }
}