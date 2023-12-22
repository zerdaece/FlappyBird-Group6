using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Speedincrease : MonoBehaviour
{
    public PointScript logic;
    public float SpeeedincreaseSpeed = 5;
    public float Despawnplace = -60;
    
    // Start is called before the first frame update
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Point").GetComponent<PointScript>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            Debug.Log("Speedincreasedtaken");
            PickupSpeedincrease();
        }
    }

    void PickupSpeedincrease()
    {
        FindObjectOfType<Audio_manager>().Play("Speed");

        logic.Speedincreasepower();

        Destroy(gameObject);
    }

    void Update()
    {
        transform.position = transform.position + (Vector3.left * SpeeedincreaseSpeed) * Time.deltaTime;

        if (transform.position.x < Despawnplace)
        {
            Debug.Log("Speedincrease gone");
            Destroy(gameObject);
        }
    }
}
