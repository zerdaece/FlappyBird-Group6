using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Towers : MonoBehaviour
{
    public float Towerspeed = 5;
    public float Despawnplace = -60;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = transform.position + (Vector3.left * Towerspeed) * Time.deltaTime;

        if (transform.position.x < Despawnplace)
        {
            Debug.Log("Tower gone");
            Destroy(gameObject);
        }
    }
}
