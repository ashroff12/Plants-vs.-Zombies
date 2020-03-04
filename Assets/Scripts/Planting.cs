using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Planting : MonoBehaviour
{
    void OnMouseUpAsButton(){
        if(BuildMenu.curPlant != null){
            Instantiate(BuildMenu.curPlant.gameObject, transform.position, Quaternion.identity);
            CollectSun.score -= BuildMenu.curPlant.price;
            BuildMenu.curPlant = null;
        }
    }
}