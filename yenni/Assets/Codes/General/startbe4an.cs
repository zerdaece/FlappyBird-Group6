using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class startbe4an : MonoBehaviour
{
    public CatScript Cat;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.layer == 3)
        {
            FindObjectOfType<Audio_manager>().Play("Nam");

            Cat.Catrigidbody.velocity = Vector2.up * Cat.Catstrenght;
        }

    }
}
