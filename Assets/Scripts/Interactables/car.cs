using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class car : Interactable
{

    public GameObject player;
    public GameObject redcar;

    public void FinishLevel() {

        
        SceneManager.LoadScene(1);

    }

}
