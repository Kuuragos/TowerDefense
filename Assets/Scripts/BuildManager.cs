using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildManager : MonoBehaviour 
{
    public static BuildManager instance;
    public GameObject torretaBasica, torretaAvanzada, torretaFuturista;
    private PlanoTorreta torretaConstruir; 
    void Awake()
    {
        if (instance != null)
        {
            Debug.LogError("Mas de un admin de edicion en escena");
            return;
        }
        instance = this;
    }
    public bool CanBuild { get { return torretaConstruir != null; } }
    public bool HasMoney { get { return MoneyCount.dinero >= torretaConstruir.costo; } }

    public void EncedidoConstruir (Nodos nodo)
    {
        if (MoneyCount.dinero < torretaConstruir.costo)
        {
            Debug.Log("ERES POBRE! No Puedes Construir Con Tan Poco Dinero");
            return;
        }

        MoneyCount.dinero -= torretaConstruir.costo;
        GameObject torre = (GameObject)Instantiate(torretaConstruir.prefab, nodo.GetBuildPosition(), Quaternion.identity);
        nodo.torreta = torre;
        Debug.Log("Construcción Completada! Dinero Restante: " + MoneyCount.dinero);
    }
    public void SetTorretaConstruir(PlanoTorreta torreta)
    {
        torretaConstruir = torreta;
    }
    
}
