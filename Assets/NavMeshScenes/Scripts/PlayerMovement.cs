using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.UI;

public class PlayerMovement : MonoBehaviour
{
    private Camera cam;
    private NavMeshAgent agent;
    private Vector3 move;

    private void Start()
    {
        cam = Camera.main;
        agent = GetComponent<NavMeshAgent>();
    }

    private void Update()
    {
        if (Time.timeScale == 0)
        {
            return;
        }
        // мышь
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hit;
            agent.speed = 10;
            if (Physics.Raycast(cam.ScreenPointToRay(Input.mousePosition), out hit, 100)) {
                agent.destination = hit.point;
            }
        } else if ((move.x = Input.GetAxis("Horizontal")) != 0 || (move.z = Input.GetAxis("Vertical")) != 0) // клавиатура
        {
            var moveDirection = new Vector3(move.x, 0, move.z);
            var movePosition = transform.position + moveDirection;
            agent.speed = 50;
            agent.SetDestination(movePosition);
        }
    }
}
