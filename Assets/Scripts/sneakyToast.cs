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


        Vector3 input = GameObject.FindWithTag("Button").transform.position - transform.position;
        
        Vector3 dir = input.normalized;
        Vector3 vel = dir * speed * Time.deltaTime;

        transform.Translate(vel);


        mySpriteRenderer.sprite = spriteWalk;
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
