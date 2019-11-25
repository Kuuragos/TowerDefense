using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class MovimientoEnemigo : MonoBehaviour
{
    public NavMeshAgent agent;
    public Camera camara;
     void Awake()
    {
        camara = Camera.main;
    }
    void Start()
    {
        agent.destination = GameObject.Find("Meta").transform.position;
    }

    void FixedUpdate()
    {
        RaycastHit hit;
        if (Physics.Raycast(camara.ScreenPointToRay(Input.mousePosition), out hit, 100))
        {
            agent.destination = hit.point;
        }
    }
}
