using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class NavMeshAnimateHumanController : MonoBehaviour
{
    [SerializeField] private Animator animator;
    [SerializeField] private NavMeshAgent agent;

    // Update is called once per frame
    void Update()
    {
        //Debug.Log("mousewalk" + agent.velocity.magnitude);
        animator.SetFloat("mousewalk", agent.velocity.magnitude);
    }
}
