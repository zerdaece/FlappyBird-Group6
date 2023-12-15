//using System.Collections;
//using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Player : MonoBehaviour
{ 
    public float gravity= -9.8f;
    public float strength = 5f;
    private Vector3 direction;
    private SpriteRenderer spriteRenderer;
    public Sprite[] sprites;
    private int spriteIndex ;
    

     /// <summary>
    /// Awake is called when the script instance is being loaded.
    /// </summary>
    private void Awake()
    {
        spriteRenderer =GetComponent<SpriteRenderer>();
    } 
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating(nameof(AnimateSprite),0.15f,0.15f);
        Cursor.visible=false;
    }
 /// <summary>
    /// This function is called when the object becomes enabled and active.
    /// </summary>
    private void OnEnable()
    {
        Vector3 position = transform.position;
        position.y = 0f;
        transform.position = position ;
        direction = Vector3.zero;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)||Input.GetMouseButton(0))
        { 
           direction=Vector3.up*strength;
        }
        direction.y += gravity*Time.deltaTime;
        transform.position += direction * Time.deltaTime;
    }
    private void AnimateSprite()
    {
        spriteIndex ++;
        if(spriteIndex >= sprites.Length)
        {
            spriteIndex = 0;
        }
        spriteRenderer.sprite= sprites[spriteIndex];
    }
     /// <summary>
    /// Sent when another object enters a trigger collider attached to this
    /// object (2D physics only).
    /// </summary>
    /// <param name="other">The other Collider2D involved in this collision.</param>
    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.tag == "Obstacle")
        {
           FindObjectOfType<GameManager>().GameOver();
        }
        else if(other.gameObject.tag == "Scoring")
        {
           FindObjectOfType<GameManager>().IncreaseScore();
        }
    }
}
