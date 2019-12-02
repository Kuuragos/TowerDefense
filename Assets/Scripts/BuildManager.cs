using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildManager : MonoBehaviour 
{
    public static BuildManager instance;
    public GameObject torretaBasica, torretaAvanzada, torretaFuturista;
    private GameObject torretaConstruir;
    void Awake()
    {
        if (instance != null)
        {
            Debug.LogError("Mas de un admin de edicion en escena");
            return;
        }
        instance = this;
    }
    public GameObject GetTorretaConstruir()
    {
        return torretaConstruir;
    }
    public void SetTorreta (GameObject torreta)
    {
        torretaConstruir = torreta;
    }
    
}
