using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CookieSpawner : MonoBehaviour
{
    int timer;
    int spawntimer;
    public GameObject Smores;
    public GameObject ThinMint;
    public GameObject Samoas;
    public GameObject Tagalongs;
    public GameObject DoSiDos;
    public GameObject SavanhaSimles;
    public GameObject trefoils;
    public GameObject ToffeTastic;
    int whatToSpawn;

    
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
            whatToSpawn = Random.Range(1, 18);
            if (whatToSpawn <= 10)
            {
                Instantiate(Samoas, startPos, Quaternion.identity);
            }
            if (whatToSpawn == 11)
            {
                Instantiate(Tagalongs, startPos, Quaternion.identity);
            }
            if (whatToSpawn == 12)
            {
                Instantiate(ThinMint, startPos, Quaternion.identity);
            }
            if (whatToSpawn == 13)
            {
                Instantiate(DoSiDos, startPos, Quaternion.identity);
            }
            if (whatToSpawn == 14)
            {
                Instantiate(SavanhaSimles, startPos, Quaternion.identity);
            }
            if (whatToSpawn == 15)
            {
                Instantiate(trefoils, startPos, Quaternion.identity);
            }
            if (whatToSpawn == 16)
            {
                Instantiate(ToffeTastic, startPos, Quaternion.identity);
            }
            if (whatToSpawn == 17)
            {
                Instantiate(Smores, startPos, Quaternion.identity);
            }
            timer = 0;
            spawntimer = Random.Range(50,100);
        }
    }
}
