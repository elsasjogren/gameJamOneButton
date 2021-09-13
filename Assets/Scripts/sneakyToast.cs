using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sneakyToast : MonoBehaviour
{

    //toast needs to walk into the screen from different directions and walk towards the button 
    private Rigidbody2D rb2d;
    private SpriteRenderer mySpriteRenderer;

    public Sprite[] walkSprite = new Sprite[5];
    public float speed;


    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        mySpriteRenderer = GetComponent<SpriteRenderer>();
    }

   
    void Update()
    {
        Sprite spriteWalk = walkSprite[Random.Range(0, walkSprite.Length)];
        mySpriteRenderer.sprite = spriteWalk;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Skull"))
        {
            Destroy(gameObject);


        }
    }

}
