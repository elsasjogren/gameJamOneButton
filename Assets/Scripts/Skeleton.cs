using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Skeleton : MonoBehaviour
{
    public float speed;
    Rigidbody2D body;

    private SpriteRenderer mySpriteRenderer;
    public Sprite spriteLeft;
    public Sprite spriteRight;

    void Start()
    {
        body = GetComponent<Rigidbody2D>();
        mySpriteRenderer = GetComponent<SpriteRenderer>();
    }

    
    void Update()
    {
        Vector2 input = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
        Vector2 movement = input * speed;

        if (Input.GetKey(KeyCode.LeftArrow))
        {
           
            mySpriteRenderer.sprite = spriteLeft;
           
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
           
            mySpriteRenderer.sprite = spriteRight;
            
        }

            body.velocity = movement;
    }
}
