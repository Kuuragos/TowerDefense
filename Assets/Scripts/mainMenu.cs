using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class mainMenu : MonoBehaviour
{
    public string levelToLoad = "SampleScene";
    //public AudioSource musica;

    void Start ()
    {
        //musica.GetComponent<AudioSource>();

    }
    public void Play()
    {
        //musica.Stop();
        SceneManager.LoadScene(levelToLoad);
    }
}
