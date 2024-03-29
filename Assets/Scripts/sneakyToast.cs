using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sneakyToast : MonoBehaviour
{

    //toast needs to walk into the screen from different directions and walk towards the button 
    private Rigidbody2D rb2d;
    private SpriteRenderer mySpriteRenderer;

    public Sprite[] walkSprite = new Sprite[5];
    static public float speed;
    //sneakyToast.speed to access in the main menu 
    

    private int frame = 0;
    private int frameIndex = 0;

    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        mySpriteRenderer = GetComponent<SpriteRenderer>();
    }


    void Update()
    {
        frame++;
        //int frameInt =  Math.Ceiling(10 / speed);
        if (frame % 20 == 0)
        {
            
            Sprite spriteWalk = walkSprite[frameIndex];
            mySpriteRenderer.sprite = spriteWalk;
            frameIndex++;
            if (frameIndex == walkSprite.Length)
            {
                frameIndex = 0;
            }
        }

        if (frame >= 1000)
        {
            frame = 0;
        }

        Vector3 input = GameObject.FindWithTag("Button").transform.position - transform.position;

        Vector3 dir = input.normalized;
        Vector3 vel = dir * speed * Time.deltaTime;

        transform.Translate(vel);

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Skull"))
        {
            Destroy(gameObject);
            Destroy(collision.gameObject);
            GameObject.Find("skullSpawner").GetComponent<SkullSpawner>().count--;
            //GameObject.Find("MyObject").GetComponent<MyScript>().MyVariable

        }
    }

}
