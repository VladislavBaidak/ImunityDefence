using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MobController : MonoBehaviour
{
    public float aggroRadius = 10f;  // ������ ���� ��������� ����
    public LayerMask aggroLayerMask; // ����, �� ������� ��������� ���������

    private Transform target; // ���� ��� �����

    void Update()
    {
        // ���������, ���� �� �������� � ���� ��������� ����
        Collider[] colliders = Physics.OverlapSphere(transform.position, aggroRadius, LayerMask.NameToLayer("Character"));

        // ���� ����, �������� ������ ��������� �������� � �������� ���� �����
        if (colliders.Length > 0)
        {
            target = colliders[0].transform;
        }
        else
        {
            target = null; // ���� �������� �� ������, �� ���� ���
        }
    }

    // ������� ��� ����� ����
    void Attack()
    {
        // ������� ������ ���� ���� ��������� � ���� ��������� ����
        if (target != null && Vector3.Distance(transform.position, target.position) < aggroRadius)
        {
            // ��� ��� ����� ����
        }
    }
}
