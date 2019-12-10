using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Vida : MonoBehaviour
{
    public TextMeshProUGUI textV;

    void Update()
    {
        textV.text ="Intentos= " + Dinero.vidas;
    }
}
