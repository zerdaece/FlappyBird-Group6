using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Clouds : MonoBehaviour
{
    public float Cloudspeed = 5;
    public float Despawnplace = -60;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = transform.position + (Vector3.left * Cloudspeed) * Time.deltaTime;

        if (transform.position.x < Despawnplace)
        {
            Debug.Log("Cloud gone");
            Destroy(gameObject);
        }
    }
}
