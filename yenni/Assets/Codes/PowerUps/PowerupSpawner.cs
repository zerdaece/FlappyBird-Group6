using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerupSpawner : MonoBehaviour
{
    public GameObject Shield;
    public GameObject Speedincrease;
    public float Spawnrate = 66;
    private float timer = 0;


    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (timer < Spawnrate)
        {
            timer = timer + Time.deltaTime;
        }
        else
        {
            float randomNumber = Random.Range(0, 5);
            if (randomNumber > 2)
            {
                SpawnShield();
                timer = 0;
            }
            else
            {
                SpawnSpeedincrease();
                timer = 0;
            }
        }
    }
    void SpawnShield()
    {
        Instantiate(Shield, new Vector3(transform.position.x, transform.position.y, 0), transform.rotation);
    }
    void SpawnSpeedincrease()
    {
        Instantiate(Speedincrease, new Vector3(transform.position.x, transform.position.y, 0), transform.rotation);
    }
}
