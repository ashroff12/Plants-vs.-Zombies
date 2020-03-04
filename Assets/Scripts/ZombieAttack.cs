using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieAttack : MonoBehaviour
{
    float last = 0;

    void OnCollisionStay2D(Collision2D coll){
        if(coll.gameObject.tag == "Plant"){
            GetComponent<Animator>().SetTrigger("IsAttacking");
            if(Time.time - last >= 1){
                coll.gameObject.GetComponent<Health>().DoDamage(1);
                last = Time.time;
            }
        }
    }
}
