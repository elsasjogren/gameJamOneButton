using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Skull : MonoBehaviour
{
    public bool thrown = false;

    private SpriteRenderer mySpriteRenderer;

    public Sprite[] skulls = new Sprite[12];

    void Start()
    { 
        mySpriteRenderer = GetComponent<SpriteRenderer>();
    }

    
    void Update()
    {
        //Sprite newSkull = skulls[Random.Range(0, skulls.Length)];
        //mySpriteRenderer.sprite = newSkull;
        // have a pile of five skulls and if there is less than 1 skull spawn two new skulls
    }


    private void OnTriggerEnter2D(Collider2D other)
    {
        // BaseObject object = other.GetComponent<BaseObject>();
        if (other != null && thrown)
        {
          StartCoroutine(waitToDestroy()); 
        }
    }

    IEnumerator waitToDestroy()
    {
        yield return new WaitForSeconds(5);
        Destroy(gameObject);
    }




}
