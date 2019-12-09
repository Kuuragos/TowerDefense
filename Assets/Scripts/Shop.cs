using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shop : MonoBehaviour
{
    public PlanoTorreta torretaBasica, torretaAvanzada, torretaFuturista;
    BuildManager builder;
    void Start()
    {
        builder = BuildManager.instance;
    }

    public void SelectTorretaBasica()
    {
        Debug.Log("Torreta Basica");
        builder.SetTorretaConstruir(torretaBasica);
    }
    public void SelectTorretaAvanzada()
    {
        Debug.Log("Torreta Avanzada");
        builder.SetTorretaConstruir(torretaAvanzada);

    }
    public void SelectTorretaFuturista()
    {
        Debug.Log("Torreta Futurista");
        builder.SetTorretaConstruir(torretaFuturista);

    }
}
