using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildManager : MonoBehaviour 
{
    public static BuildManager instance;
    public GameObject torretaBasica;
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

    void Start()
    {
        torretaConstruir = torretaBasica;
    }
    public GameObject GetTorretaConstruir()
    {
        return torretaConstruir;
    }
}
