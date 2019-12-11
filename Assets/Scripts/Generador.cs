using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Generador : MonoBehaviour
{
    public GameObject necromancer, skeleton, boo;
    [Space]
    public int enemigosOleada, numOleadas;
    public float frecEnemigos, frecOleadas;

    int contarOleadas = 0;
    int numOleadaActual = 0;
    bool oleadaEnCurso = true;
     void Start()
    {
        SpawnOleadas();
    }
    void FixedUpdate()
    {
        if (!oleadaEnCurso)
        {
            if (contarOleadas < numOleadas)
            {
                oleadaEnCurso = true;
                Invoke("SpawnOleadas", frecOleadas);
            }
            else
                contarOleadas = 0;
        }
    }
    void SpawnEnemigo()
    {
        if (GameManager.gameEnded == false)
        {
            int nE = Random.Range(0, 3);
            GameObject enemigo;
            switch (nE)
            {
                case 0:
                    enemigo = Instantiate(necromancer, transform.position, Quaternion.identity);
                    break;
                case 1:
                    enemigo = Instantiate(skeleton, transform.position, Quaternion.identity);
                    break;
                case 2:
                    enemigo = Instantiate(boo, transform.position, Quaternion.identity);
                    break;
            }
        }
        
    }
    void LlamarOleadas()
    {
        CrearOleadas(enemigosOleada, frecEnemigos);
    }
    void CrearOleadas(int numEnemy, float frecuencia)
    {
        SpawnEnemigo();
        numOleadaActual++;
        if (numOleadaActual < numEnemy)
        {
            oleadaEnCurso = true;
            Invoke("LlamarOleadas", frecuencia);
        }
        else
        {
            CancelInvoke("LlamarOleadas");
            numOleadaActual = 0;
            oleadaEnCurso = false;
        }
    }
    void SpawnOleadas()
    {
        CrearOleadas(enemigosOleada, frecEnemigos);
        contarOleadas++;
    }
}
