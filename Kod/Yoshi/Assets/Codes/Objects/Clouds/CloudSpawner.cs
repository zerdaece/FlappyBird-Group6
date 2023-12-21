using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloudSpawner : MonoBehaviour
{

    public GameObject Cloud0;
    public GameObject Cloud1;
    public GameObject Cloud2;
    public GameObject Cloud3;
    public GameObject Cloud4;
    public GameObject Cloud5;
    public GameObject Cloud6;

    public float Spawnrate = 11;
    private float timer = 0;
    public float heightoffset = 10;

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
            float randomnumber = Random.Range(1, 8);
            if(randomnumber == 1)
            {
                spawncloud1();
            }
            if (randomnumber == 2)
            {
                spawncloud2();
            }
            if (randomnumber == 3)
            {
                spawncloud3();
            }
            if (randomnumber == 4)
            {
                spawncloud4();
            }
            if (randomnumber == 5)
            {
                spawncloud5();
            }
            timer = randomnumber;

        }
    }
    void spawncloud1()
    {
        float lowPoint = transform.position.y - heightoffset;
        float highPoint = transform.position.y + heightoffset;

        Instantiate(Cloud0, new Vector3(transform.position.x, Random.Range(lowPoint, highPoint), 2), transform.rotation);

    }
    void spawncloud2()
    {
        float lowPoint = transform.position.y - heightoffset;
        float highPoint = transform.position.y + heightoffset;

        Instantiate(Cloud1, new Vector3(transform.position.x, Random.Range(lowPoint, highPoint), 2), transform.rotation);

    }
    void spawncloud3()
    {
        float lowPoint = transform.position.y - heightoffset;
        float highPoint = transform.position.y + heightoffset;

        Instantiate(Cloud2, new Vector3(transform.position.x, Random.Range(lowPoint, highPoint), 2), transform.rotation);

    }
    void spawncloud4()
    {
        float lowPoint = transform.position.y - heightoffset;
        float highPoint = transform.position.y + heightoffset;

        Instantiate(Cloud3, new Vector3(transform.position.x, Random.Range(lowPoint, highPoint), 2), transform.rotation);

    }
    void spawncloud5()
    {
        float lowPoint = transform.position.y - heightoffset;
        float highPoint = transform.position.y + heightoffset;

        Instantiate(Cloud4, new Vector3(transform.position.x, Random.Range(lowPoint, highPoint), 2), transform.rotation);

    }
    void spawncloud6()
    {
        float lowPoint = transform.position.y - heightoffset;
        float highPoint = transform.position.y + heightoffset;

        Instantiate(Cloud5, new Vector3(transform.position.x, Random.Range(lowPoint, highPoint), 2), transform.rotation);

    }
}

