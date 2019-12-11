using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class mainMenu : MonoBehaviour
{
    public string levelToLoad = "SampleScene";
    public void Play()
    {
        SceneManager.LoadScene(levelToLoad);
    }
}
