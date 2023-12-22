using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{   
    public GameObject prefab;
    public float spawnRate = 1f;
    public float minHeight = -1f;
    public float maxHeight = 1f;
    /// This function is called when the object becomes enabled and active.
    private void OnEnable()
    {
        InvokeRepeating(nameof(Spawn),spawnRate,spawnRate);
    }
    /// This function is called when the behaviour becomes disabled or inactive.
    private void OnDisable()
    {
        CancelInvoke(nameof(Spawn));
    }
    private void Spawn()
    {
        GameObject pipes = Instantiate(prefab,transform.position,Quaternion.identity);
        pipes.transform.position += Vector3.up*Random.Range(minHeight,maxHeight);
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
