using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
   


    public void PlayGame()
    {
        SceneManager.LoadScene(0);

    }
    public void Github()
    {
        Application.OpenURL("https://github.com/peterk377/ZombieHuntBeta");
    }

    public void Controls()
    {
        Application.OpenURL("https://github.com/peterk377/ZombieHuntBeta");
    }
}