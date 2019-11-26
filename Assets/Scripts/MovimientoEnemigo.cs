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
        int controlC = Random.Range(0, 3);
        if (agent.hasPath == false)
        {
            switch (controlC)
            {
                case 0:
                    agent.destination = GameObject.Find("Top").transform.position;
                    Invoke("LlamarMeta", 14.5f);
                    break;
                case 1:
                    agent.destination = GameObject.Find("Meta").transform.position;
                    break;
                case 2:
                    agent.destination = GameObject.Find("Bot").transform.position;
                    Invoke("LlamarMeta", 18.5f);
                    break;
            }
        }

    }

    void LlamarMeta()
    {
        agent.destination = GameObject.Find("Meta").transform.position;

    }

    
}
