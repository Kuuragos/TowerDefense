using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dinero : MonoBehaviour
{
    public static int vidas;
    public int startMoney = 400;
    public int vidaInicial = 10;
    void Start()
    {
        vidas = vidaInicial;
        MoneyCount.dinero = startMoney;  
    }
}
