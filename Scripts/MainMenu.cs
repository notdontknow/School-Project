using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void PlayGame()
    {
        // Replace "SceneName" with the actual name of your scene or use an index.
        SceneManager.LoadSceneAsync("Main Menu"); // Use a string name or scene index number
    }
}
