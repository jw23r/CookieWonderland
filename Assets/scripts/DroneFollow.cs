using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DroneFollow : MonoBehaviour
{
    public Transform target;
    public float speed = .05f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 needToMove = new Vector3();
        
        needToMove = target.position - transform.position;
        transform.position += needToMove * speed;
    }
}
