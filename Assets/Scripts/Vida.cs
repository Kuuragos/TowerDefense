using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Vida : MonoBehaviour
{
    public int vidaInicial = 10;
    public static int vidas;
    public Image barrita;
    void Start()
    {
        vidas = vidaInicial;
    }
}
