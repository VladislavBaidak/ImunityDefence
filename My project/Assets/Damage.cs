using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Damage : MonoBehaviour
{
    public int damage;

    // Update is called once per frame
    void OnTriggerEnter(Collider  myCollider)
    {
        if (myCollider.tag == ("Character"))
        {
            myCollider.GetComponent<Character>().TakeDamage(damage);
        }
    }
}
