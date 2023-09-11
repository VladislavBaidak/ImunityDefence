using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class BossTarget : MonoBehaviour
{
    private NavMeshAgent myAgent;
    private Animator myAnimator;
    private float distance;
    private Transform target;
    // Start is called before the first frame update

    void Start()
    {
        target = GameObject.Find("Character").transform;
        myAgent = GetComponent<UnityEngine.AI.NavMeshAgent>();
        myAnimator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {

        distance = Vector3.Distance(target.position, transform.position);
        if (distance > 100)
        {
            myAgent.enabled = false;
            myAnimator.Play("Idle");

        }
        if (distance < 100 & distance > 4f)
        {
            myAgent.enabled = true;
            myAgent.SetDestination(target.position);
            myAnimator.Play("Idle");
        }
        if (distance <= 4f)
        {
            myAgent.enabled = true;
            myAnimator.Play("BossAttack");
        }
    }
}
