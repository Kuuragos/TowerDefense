using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Nodos : MonoBehaviour
{
    BuildManager builder;
    private Renderer render;
    public GameObject torreta;
    public Color hoverColor, sinDineroColor;
    private Color startColor;
    public Vector3 posicionActual;
    void Start()
    {
        render = GetComponent<Renderer>();
        startColor = render.material.color;

        builder = BuildManager.instance;
    }
    public Vector3 GetBuildPosition()
    {
        return transform.position + posicionActual;
    }
    void OnMouseDown()
    {
        if (EventSystem.current.IsPointerOverGameObject())
            return;
        if (!builder.CanBuild)
            return;
        if (torreta != null)
        {
            Debug.Log("No Puedes construir de nuevo ahí");
            return;
        }
        builder.EncedidoConstruir(this);
    }

    void OnMouseEnter()
    {
        if (EventSystem.current.IsPointerOverGameObject())
            return;
        if (!builder.CanBuild)
            return;
        if(builder.HasMoney)
        {
            render.material.color = hoverColor;

        }
        else
        {
            render.material.color = sinDineroColor;
        }
    }
    void OnMouseExit()
    {
        render.material.color = startColor;   
    }
}
