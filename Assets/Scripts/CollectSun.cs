using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectSun : MonoBehaviour
{
    // Start is called before the first frame update
    public static int score = 100;
    void OnMouseDown(){
        score += 100000;

        Destroy(gameObject);
    }
}
