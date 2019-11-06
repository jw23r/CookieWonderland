using UnityEngine;

public class CookieBehavior : MonoBehaviour
{
    // Start is called before the first frame update
    int scaler;
    bool destroy = false;
    public int rangeMin = 1;
    public int rangeMax = 6;

    void Start()
    {
        scaler = Random.Range(rangeMin, rangeMax);
        transform.localScale = new Vector3(scaler, scaler, scaler);
    }

    // Update is called once per frame
    void Update()
    {
        /**if (turn == false)
        {
            transform.Translate(Vector3.back * Time.deltaTime * 20);
        }**/
       // if (turn == true)
       // {
            transform.Translate(Vector3.right * Time.deltaTime * 20);

       // }
       if (destroy == true)
        {
Destroy(this.gameObject);
            print("help");
        }

    }
  void onTriggerEneter(Collider collider)
    {
        if (collider.transform.tag == "Destroy")
        {
            
            print("hit");
            destroy = true;

        }
    }
}

