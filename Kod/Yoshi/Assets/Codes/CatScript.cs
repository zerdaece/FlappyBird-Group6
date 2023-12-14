using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using Unity.VisualScripting.Dependencies.NCalc;
using UnityEngine;

public class CatScript : MonoBehaviour
{
    public Rigidbody2D Catrigidbody;
    public float Catstrenght;
    public PointScript logic;
    public bool catisdead = false;
    // Start is called before the first frame update
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Point").GetComponent<PointScript>();

    }

    // Update is called once per frame
    void Update()
    {
        if ((Input.GetKeyDown(KeyCode.W)) == true && catisdead == false)
        {
            Catrigidbody.velocity = Vector2.up * Catstrenght;
        }
        if ((Input.GetKeyDown(KeyCode.D)) == true && catisdead == false)
        {
            Catrigidbody.velocity = Vector2.down * 2 * Catstrenght;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        logic.gameover();
        catisdead = true;
    }
}

