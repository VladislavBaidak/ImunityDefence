using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MobController : MonoBehaviour
{
    public float aggroRadius = 10f;  // радиус зоны видимости моба
    public LayerMask aggroLayerMask; // слой, на котором находятся персонажи

    private Transform target; // цель для атаки

    void Update()
    {
        // проверяем, есть ли персонаж в зоне видимости моба
        Collider[] colliders = Physics.OverlapSphere(transform.position, aggroRadius, LayerMask.NameToLayer("Character"));

        // если есть, выбираем первый найденный персонаж в качестве цели атаки
        if (colliders.Length > 0)
        {
            target = colliders[0].transform;
        }
        else
        {
            target = null; // если персонаж не найден, то цели нет
        }
    }

    // функция для атаки цели
    void Attack()
    {
        // атакуем только если цель находится в зоне видимости моба
        if (target != null && Vector3.Distance(transform.position, target.position) < aggroRadius)
        {
            // код для атаки цели
        }
    }
}
