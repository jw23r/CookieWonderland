using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CookieSpawner : MonoBehaviour
{
    int timer;
    int spawntimer;
    public GameObject Smores;
    Vector3 startPos;
    // Start is called before the first frame update
    void Start()
    {
        startPos = gameObject.transform.position;

        print("spawn");
    }

    // Update is called once per frame
    void Update()
    {
        SpawCookie();
    }
   public void SpawCookie()
    {
        timer += 1;
        if (timer >= spawntimer)
        {
    Instantiate(Smores, startPos , Quaternion.identity);
            timer = 0;
            spawntimer = Random.Range(100, 200);
        }
    }
}
