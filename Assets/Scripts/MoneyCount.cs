﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class MoneyCount : MonoBehaviour
{
    public static int dinero;
    public TextMeshProUGUI moneyText;

    void Update()
    {
        moneyText.text = "$" + dinero;
    }
}
