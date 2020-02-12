using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    [SerializeField]
    int currentHealth = 5;

    public void DoDamage(int n){

        currentHealth -=n;

        if(currentHealth <=0){
            Destroy(gameObject);
        }
    }
   
}
