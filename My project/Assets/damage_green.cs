using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading;
using UnityEngine;

public class damage_green : MonoBehaviour
{
    public int damagePerSecond = 5; // количество урона в секунду

    private bool isDamaging = false;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Character"))
        {
            isDamaging = true;
            StartCoroutine(DealDamage(other));
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Character"))
        {
            isDamaging = false;
        }
    }

    private IEnumerator DealDamage(Collider other)
    {
        while (isDamaging)
        {
            other.GetComponent<Character>().TakeDamage(damagePerSecond); 
            yield return new WaitForSeconds(1f);
        }
    }
}

