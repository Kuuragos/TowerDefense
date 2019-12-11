using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverIA : MonoBehaviour
{
    public void Retry()
    {
        SceneManager.LoadScene(0);
    }

    public void Menu()
    {
        
    }
}
