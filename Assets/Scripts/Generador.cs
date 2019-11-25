using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Generador : MonoBehaviour
{
    public GameObject dragon, skeleton;
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
        int nE = Random.Range(0, 2);
        if (nE == 0)
        {
            GameObject enemigo = Instantiate(dragon, transform.position, Quaternion.identity);

        }
        else if (nE == 1)
        {
            GameObject enemigo = Instantiate(skeleton, transform.position, Quaternion.identity);

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
            Invoke("crearOleadas", frecuencia);
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
