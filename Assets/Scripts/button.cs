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

    private void OnCollisionEnter2D(Collision2D col)
    {
        mySpriteRenderer.sprite = pressDown;
        if (col.gameObject.CompareTag("Skull"))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}
