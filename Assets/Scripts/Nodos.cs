using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Nodos : MonoBehaviour
{
    private Renderer render;
    private GameObject torreta;
    public Color hoverColor;
    private Color startColor;
    public Vector3 posicionActual;
    void Start()
    {
        render = GetComponent<Renderer>();
        startColor = render.material.color;
    }

    void OnMouseDown()
    {
        if (torreta != null)
        {
            Debug.Log("No Puedes construir de nuevo ahí");
            return;
        }
        GameObject construccionT = BuildManager.instance.GetTorretaConstruir();
        torreta = (GameObject)Instantiate(construccionT, transform.position + posicionActual, transform.rotation);
    }

    void OnMouseEnter()
    {
        render.material.color = hoverColor;  
    }
    void OnMouseExit()
    {
        render.material.color = startColor;   
    }
}
