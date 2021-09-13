using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class throwItem : MonoBehaviour
{
    public float throwForce;
    Transform thing = null;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
           if (thing != null)
            {
                Vector2 input = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
                if(input.magnitude == 0)
                {
                    input = Vector2.right;
                }

                Skull skull = thing.GetComponent<Skull>();
                skull.thrown = true;

                Rigidbody2D body = thing.GetComponent<Rigidbody2D>();
                body.simulated = true;
                thing.SetParent(null);
                body.velocity = input * throwForce;
                thing = null;
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D item)
    {
        Skull skull = item.GetComponent<Skull>();
        //grab the object of type Skull

        if (skull != null)
        {
            if (thing == null && !skull.thrown) {

                thing = item.transform;
                thing.SetParent(transform);
                thing.localPosition = new Vector3(0.5f, 0, 0);
                Rigidbody2D rb2d = thing.GetComponent<Rigidbody2D>();
                rb2d.simulated = false;

            }
            return;
        }
    }
}
