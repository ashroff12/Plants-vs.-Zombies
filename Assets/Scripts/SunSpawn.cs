using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SunSpawn : MonoBehaviour
{
    public GameObject prefab;
    void Start()
    {
        InvokeRepeating("spawn", 10, 10);
    }

   void spawn(){
       Instantiate(prefab, transform.position, Quaternion.identity);
    
   }
    
}
