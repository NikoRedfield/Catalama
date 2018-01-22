using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour {

    Transform objective;
    UnityEngine.AI.NavMeshAgent agent;


    void Start()
    {
        objective = GameObject.FindGameObjectWithTag("Objective").transform;
        agent = GetComponent<UnityEngine.AI.NavMeshAgent>();
    }


    void Update()
    {
        
            agent.SetDestination(objective.position);
    }
}
