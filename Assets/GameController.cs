using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public float timer;
    [SerializeField]
    float timerMax = 120;
    public float chocolate = 60;
    
    public float chocolateMax = 60;

    public float score;

    [SerializeField]
     float timePenalty = 5;

    [Range(0,10)] public float scoreMultiplier = 2;

    public bool gameActive = false;

    public bool chocolateFlowing = true;
    public bool paused = false;

    public List<ParticleSystem> chocolateStreams = new List<ParticleSystem>();
    public GameObject chocolateCollider;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {        
        //enter to start game
        if (Input.GetKeyDown(KeyCode.Return)){
            Reset();
            gameActive = true;
        }
        //while game is running
        if (gameActive && !paused)
        {
            timer -= Time.deltaTime;

            if(timer <= 0)
            {
                GameOver();
                print("Time is up, you win!");
            }
            if (chocolateFlowing)
            {
                //print(chocolate);
                chocolate -= Time.deltaTime;
                if(chocolate <= 0)
                {
                    print("Out of Chocolate");
                    GameOver();
                }
            }
            if (Input.GetKeyDown(KeyCode.Space) && chocolate > 0)
            {
                ToggleChocolate();
            }
        }
    }

    public void GameOver()
    {
        gameActive = !gameActive;
        print("Game Over");

        //turn the chocolate streams off
        chocolateFlowing = true;
        ToggleChocolate();
    }

    public void ToggleChocolate()
    {
        chocolateFlowing = !chocolateFlowing;
        foreach(ParticleSystem p in chocolateStreams)
        {
            if (chocolateFlowing)
            {
                p.Play();                
            }
            if (!chocolateFlowing)
            {
                p.Stop();
            }
        }        
        chocolateCollider.SetActive(chocolateFlowing);
    }

    public void TimePenalty()
    {
        if (gameActive)
        {
        timer -= timePenalty;
        print("Hit the wrong one!");
        }
    }

    public void Score( float newPoints)
    {
        if (gameActive)
        {
        score += scoreMultiplier * newPoints;
        //print(score);
        }
    }

    public void Reset()
    {
        GameOver();
        timer = timerMax;
        chocolate = chocolateMax;
        score = 0;
    }
}
