using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.UI;

public class MovimientoEnemigo : MonoBehaviour
{
    public NavMeshAgent agent;
    public Camera camara;
    public float saludInicial = 100;
    public float salud;
    public int lootDinero = 25;
    public Image barraSalud;
   
     void Awake()
    {
        camara = Camera.main;
        salud = saludInicial;
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

    public void RecibirDaño (int cantidad)
    {
        salud = salud - cantidad;
        barraSalud.fillAmount = salud / saludInicial;
        if (salud<=0)
        {
            Die();
        }
    }

    private void Die()
    {
        MoneyCount.dinero += lootDinero;
        Destroy(gameObject);
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            EndPath();
        }
    }

    private void EndPath()
    {
        Vida.vidas--;
        Destroy(gameObject);
    }

    void LlamarMeta()
    {
        agent.destination = GameObject.Find("Meta").transform.position;

    }

    
}
