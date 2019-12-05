using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CookieSpawner : MonoBehaviour
{
    float timer;
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
    Vector3 rand;
    // Start is called before the first frame update
    void Start()
    {
        startPos = gameObject.transform.position;
        rand = new Vector3(0, 0, Random.Range(-5,6));
        print("spawn");
    }

    // Update is called once per frame
    void Update()
    {
        SpawCookie();
    }
   public void SpawCookie()
    {
        timer += Time.deltaTime;
        if (timer >= spawntimer)
        {
            whatToSpawn = Random.Range(1, 18);
            if (whatToSpawn <= 10)
            {
                Instantiate(Samoas, startPos + rand , Quaternion.identity);
            }
            if (whatToSpawn == 11)
            {
                Instantiate(Tagalongs, startPos + rand, Quaternion.identity);
            }
            if (whatToSpawn == 12)
            {
                Instantiate(ThinMint, startPos + rand, Quaternion.identity);
            }
            if (whatToSpawn == 13)
            {
                Instantiate(DoSiDos, startPos + rand, Quaternion.identity);
            }
            if (whatToSpawn == 14)
            {
                Instantiate(SavanhaSimles, startPos + rand, Quaternion.identity);
            }
            if (whatToSpawn == 15)
            {
                Instantiate(trefoils, startPos + rand, Quaternion.identity);
            }
            if (whatToSpawn == 16)
            {
                Instantiate(ToffeTastic, startPos + rand, Quaternion.identity);
            }
            if (whatToSpawn == 17)
            {
                Instantiate(Smores, startPos + rand, Quaternion.identity);
            }
            timer = 0;
            spawntimer = Random.Range(1,6);
        }
    }
}
