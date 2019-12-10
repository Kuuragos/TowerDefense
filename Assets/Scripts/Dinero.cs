using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dinero : MonoBehaviour
{
    public int startMoney = 400;
    void Start()
    {
        MoneyCount.dinero = startMoney;  
    }
}
