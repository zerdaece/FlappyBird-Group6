using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Towers : MonoBehaviour
{
    public Towerspeed speed;
    public float Despawnplace = -60;

    // Start is called before the first frame update
    void Start()
    {
        speed = GameObject.FindGameObjectWithTag("SP").GetComponent<Towerspeed>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = transform.position + (Vector3.left * speed.towerspeed) * Time.deltaTime;

        if (transform.position.x < Despawnplace)
        {
            Debug.Log("Tower gone");
            Destroy(gameObject);
        }
    }
}
