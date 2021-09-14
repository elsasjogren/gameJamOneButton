using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class button : MonoBehaviour
{
    private SpriteRenderer mySpriteRenderer;
    public Sprite pressDown;
    public Sprite jamExplosion;


    void Start()
    {
        mySpriteRenderer = GetComponent<SpriteRenderer>();
    }

   
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        
        if (col.gameObject.CompareTag("enemy"))
        {
            StartCoroutine(Wait());
            // wait is the parameter of the start coroutine function 
        }
    }



    IEnumerator Wait()
    {
        mySpriteRenderer.sprite = pressDown;
        yield return new WaitForSeconds(1); //WaitForSeconds is of type IEnumerator
        mySpriteRenderer.sprite = jamExplosion;
        yield return new WaitForSeconds(2);
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }


}
