using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class NewBehaviourScript : MonoBehaviour
{
    public NavMeshAgent agent;
    public Camera camara;

    void Start()
    {
        agent.destination = GameObject.Find("Base").transform.position;
    }

    void FixedUpdate()
    {
        RaycastHit hit;
        if (Physics.Raycast(camara.ScreenPointToRay(Input.mousePosition), out hit, 100))
            agent.destination = hit.point;
    }
}
