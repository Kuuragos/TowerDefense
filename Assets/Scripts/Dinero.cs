using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dinero : MonoBehaviour
{
    public int startMoney = 100;
    void Start()
    {
        MoneyCount.dinero = startMoney;  
    }
}
