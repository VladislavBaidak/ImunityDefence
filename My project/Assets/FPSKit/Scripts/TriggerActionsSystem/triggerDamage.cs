using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class triggerDamage : MonoBehaviour
{

    void Damage (Collider myCollider)
    {
        if (myCollider.tag == ("Player"))
        {
            myCollider.GetComponent <Character> ().currentHealth -=10;

        }
    }
}
