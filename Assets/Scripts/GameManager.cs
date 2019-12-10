﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private bool gameEnded = false;

   void Update()
    {
        if (gameEnded) return;
        if (Vida.vidas <= 0)
        {
            EndGame();
        }  
    }
    private void EndGame()
    {
        gameEnded = true;
        Debug.Log("Fin del Juego: ERES UN MANCO");
    }
}
