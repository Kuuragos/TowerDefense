using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static bool gameEnded = false;
    public GameObject gameOverIA;

    public static AudioSource musica;
    public  AudioSource sonido;
    public  AudioSource tasdingo;

    void Start()
    {
        musica=GetComponent<AudioSource>();
        tasdingo=GetComponent<AudioSource>();

        gameEnded = false; 
        musica=sonido;
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
        musica.Stop();
        gameOverIA.SetActive(true);
        Debug.Log("Fin del Juego: ERES UN MANCO");
        tasdingo.Play();

    }
}
