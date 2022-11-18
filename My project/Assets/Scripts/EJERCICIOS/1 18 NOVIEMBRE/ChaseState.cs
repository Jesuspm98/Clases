using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChaseState : State
{
    public float chaseSpeed = 3.5f;
    public float idleDistance;
    public float attackDistance;

    public State attackState;
    public State idleState;

    public override State RunCurrentState()
    {
        if (Vector3.Distance(transform.position, player.position) > idleDistance)
        {
            return idleState;
        }
        else if (Vector3.Distance(transform.position, player.position) < attackDistance)
        {
            return attackState;
        }
        else
        {
            agent.destination = player.position;
            agent.speed = chaseSpeed;
            return this;
        }
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, attackDistance);
    }
}