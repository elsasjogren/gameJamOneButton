using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Skull : MonoBehaviour
{
    public bool thrown = false;

    private void OnTriggerEnter2D(Collider2D other)
    {
       // BaseObject object = other.GetComponent<BaseObject>();
       if (other != null && thrown)
        {
            Destroy(gameObject);
       }
    }


}
