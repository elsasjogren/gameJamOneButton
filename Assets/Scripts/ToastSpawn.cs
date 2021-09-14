using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToastSpawn : MonoBehaviour
{
    public GameObject myPrefab;
    private int frame = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (frame % 500 == 0) {
            Vector3 pos = new Vector3(Random.Range(-8.0f, -7.0f), Random.Range(-5.0f, 5.0f), 0);
            Instantiate(myPrefab, pos, Quaternion.identity);
            wait();
        }
        frame++;

        if (frame == 10000) { //increases as the game goes on 
            frame = 0;
        }


    }

    IEnumerator wait()
    {
        yield return new WaitForSeconds(5);
    }
}
