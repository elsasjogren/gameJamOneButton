using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class button : MonoBehaviour
{
    private SpriteRenderer mySpriteRenderer;
    public Sprite pressDown;


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
            mySpriteRenderer.sprite = pressDown;
            //huge explosion happens of jam and butter 
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}
