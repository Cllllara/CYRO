using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public MainMenu MainMenu;
    /*bool gameHasEnded = false;

    public float restartDelay = 1f;

    public GameObject completeLevelUI;*/

    public void ReturnMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }

}