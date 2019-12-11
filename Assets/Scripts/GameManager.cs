using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static bool gameEnded = false;
    public GameObject gameOverIA;

    void Start()
    {
        gameEnded = false; 
    }

    void Update()
    {
        if (gameEnded) return;

        if (Input.GetKeyDown("y"))
            EndGame();

        if (Dinero.vidas <= 0)
        {
            EndGame();
        }  
    }
    private void EndGame()
    {
        gameEnded = true;
        gameOverIA.SetActive(true);
        Debug.Log("Fin del Juego: ERES UN MANCO");
    }
}
