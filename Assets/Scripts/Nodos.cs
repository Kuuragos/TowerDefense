using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Nodos : MonoBehaviour
{
    BuildManager builder;
    private Renderer render;
    private GameObject torreta;
    public Color hoverColor;
    private Color startColor;
    public Vector3 posicionActual;
    void Start()
    {
        render = GetComponent<Renderer>();
        startColor = render.material.color;

        builder = BuildManager.instance;
    }

    void OnMouseDown()
    {
        if (EventSystem.current.IsPointerOverGameObject())
            return;
        if (builder.GetTorretaConstruir() == null)
            return;
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
        if (EventSystem.current.IsPointerOverGameObject())
            return;
        if (builder.GetTorretaConstruir()==null)
            return;

      render.material.color = hoverColor;
    }
    void OnMouseExit()
    {
        render.material.color = startColor;   
    }
}
