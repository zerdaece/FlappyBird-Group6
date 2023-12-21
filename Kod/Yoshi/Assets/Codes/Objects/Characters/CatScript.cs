using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using Unity.VisualScripting.Dependencies.NCalc;
using UnityEngine;

public class CatScript : MonoBehaviour
{
    [SerializeField]
    private float invincibilityDurationSeconds;

    public Rigidbody2D Catrigidbody;
    public float Catstrenght;
    public PointScript logic;
    public bool catisdead = false;
    public bool Highspeed = false;

 
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Point").GetComponent<PointScript>();

    }

   
    void Update()
    {
        if ((Input.GetKeyDown(KeyCode.W)) == true && Highspeed == false && catisdead == false)
        {
            Catrigidbody.velocity = Vector2.up * Catstrenght;
        }
        if ((Input.GetKeyDown(KeyCode.D)) == true && Highspeed == false && catisdead == false)
        {
            Catrigidbody.velocity = Vector2.down * 2 * Catstrenght;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (logic.shieldtruefalse == true)
        {
            logic.shieldlosing();
            FindObjectOfType<Audio_manager>().Play("ShieldGone");

        }
        else 
        {
            logic.gameover();
            logic.ScoreCatpawns.transform.position = new Vector3(1000, 670, 0);
            catisdead = true;

        }
    }


}

