using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class MovimientoEnemigo : MonoBehaviour
{
    public NavMeshAgent agent;
    public Camera camara;
    public bool complete = false;
     void Awake()
    {
        camara = Camera.main;
    }
    void Start()
    {
        complete = agent.hasPath;
        int controlC = Random.Range(0, 3);
        if (complete == false)
        {
            switch (controlC)
            {
                case 0:
                    agent.destination = GameObject.Find("Top").transform.position;
                    complete = true;
                    break;
                case 1:
                    agent.destination = GameObject.Find("Mid").transform.position;
                    complete = true;
                    break;
                case 2:
                    agent.destination = GameObject.Find("Bot").transform.position;
                    complete = true;
                    break;
            }
        }
        else if (complete == true)
        {
            agent.destination = GameObject.Find("Meta").transform.position;

        }

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
