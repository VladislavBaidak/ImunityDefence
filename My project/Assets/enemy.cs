using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class enemy : MonoBehaviour
{
    private NavMeshAgent myAgent;
    private Animator myAnimator;
    private float distance;
    private Transform target;


    // Start is called before the first frame update
    void Start()
    {
        target = GameObject.Find("Character").transform; 
        myAgent = GetComponent<NavMeshAgent>();
        myAnimator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        distance = Vector3.Distance(target.position, transform.position);
        if(distance > 15)
        {
            myAgent.enabled = false;
            myAnimator.Play("Idle");

        }
        if (distance < 15 & distance > 2.1f)
        {
            myAgent.enabled = true;
            myAgent.SetDestination(target.position);
            myAnimator.Play("3");
        }
        if (distance <= 2f)
        {
            myAgent.enabled = true;
            myAnimator.Play("New Animation");
        }
    }
}
