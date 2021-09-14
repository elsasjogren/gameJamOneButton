using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkullSpawner : MonoBehaviour
{
    public GameObject myPrefab;
    public int count = 0;
    
    void Start()
    {
        
    }

    
    void Update()
    { 
        if (count < 1)
        {
            Vector3 pos = new Vector3(0, 0, 0);
            Instantiate(myPrefab, pos, Quaternion.identity);
            count++;
        }
    }
}
