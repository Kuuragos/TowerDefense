using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shop : MonoBehaviour
{
    BuildManager builder;
    void Start()
    {
        builder = BuildManager.instance;
    }

    public void comprarTorretaBasica()
    {
        Debug.Log("Torreta Basica");
        builder.SetTorreta(builder.torretaBasica);
    }
    public void comprarTorretaAvanzada()
    {
        Debug.Log("Torreta Avanzada");
        builder.SetTorreta(builder.torretaAvanzada);
    }
    public void comprarTorretaFuturista()
    {
        Debug.Log("Torreta Futurista");
        builder.SetTorreta(builder.torretaFuturista);
    }
}
