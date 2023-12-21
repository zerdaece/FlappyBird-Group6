using System.Collections;
using System.Collections.Generic;
using System.Data;
using UnityEngine;

public class ShieldPower : MonoBehaviour
{
    public PointScript logic;
    public float ShieldSpeed = 5;
    public float Despawnplace = -60;

    public void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Point").GetComponent<PointScript>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Player"))
        {
            Debug.Log("shieldtaken");
            pickupshield();
        }
    }
    void pickupshield()
    {
        FindObjectOfType<Audio_manager>().Play("Shiled");

        logic.shieldpower();

        Destroy(gameObject);
    }

    void Update()
    {
        transform.position = transform.position + (Vector3.left * ShieldSpeed) * Time.deltaTime;

        if (transform.position.x < Despawnplace)
        {
            Debug.Log("Shield gone");
            Destroy(gameObject);
        }
    }
}
