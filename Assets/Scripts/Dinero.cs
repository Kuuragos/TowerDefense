using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dinero : MonoBehaviour
{
    public int startMoney = 400; public int vidaInicial = 10;
    public static int vidas;
    void Start()
    {
        vidas = vidaInicial; MoneyCount.dinero = startMoney;
    }
}
