using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class SafePathController : MonoBehaviour
{
    public Transform[] points;
    private int destPoint = 0;
    private NavMeshAgent agent;

    void Start()
    {
        agent = GetComponent<NavMeshAgent>();

        // Отключение автоматического торможения позволяет осуществлять непрерывное движение
        // между точками (т.е. агент не тормозит, так как
        // приближается к точке назначения).
        agent.autoBraking = false;

        GotoNextPoint();
    }

    void GotoNextPoint() 
    {
        // Возвращается, если точки не были установлены
        if (points.Length == 0)
        return;

        // Настройте агента на поездку в выбранный в данный момент пункт назначения.
        agent.destination = points[destPoint].position;

        // Выбираем следующую точку массива в качестве пункта назначения,
        // при необходимости возвращаемся к началу.
        destPoint = (destPoint + 1) % points.Length;
        }

    void Update()
    {
        // Выбираем следующую точку назначения, когда агент получит
        // близко к текущему.
        if (!agent.pathPending && agent.remainingDistance < 0.5f)
            GotoNextPoint();
    }
}
