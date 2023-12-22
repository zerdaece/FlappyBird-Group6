using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerSpawner : MonoBehaviour
{
    public GameObject tower;
    public GameObject GoldenTower;
    public float Spawnrate = 99999;
    private float timer = 0;
    public float heightOffset = 10;

    // Start is called before the first frame update
    void Start()
    {
        timer = 10;
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
            float randomNumber = Random.Range(0, 55);
            if (randomNumber == 5)
            {
                spawngoldentower();
                timer = 0;
            }
            else
            {
                spawntower();
                timer = 0;
            }

        }
        void spawntower()
        {
            float lowPoint = transform.position.y - heightOffset;
            float highPoint = transform.position.y + heightOffset;

            Instantiate(tower, new Vector3(transform.position.x, Random.Range(lowPoint, highPoint), 0), transform.rotation);

        }
        void spawngoldentower()
        {
            float lowPoint = transform.position.y - heightOffset;
            float highPoint = transform.position.y + heightOffset;

            Instantiate(GoldenTower, transform.position, transform.rotation);

        }
    }
}
