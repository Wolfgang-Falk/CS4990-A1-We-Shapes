using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuButtons : MonoBehaviour
{
    // Start is called before the first frame update
    public void StartGame(string sceneName)
    {
        Debug.Log("Attempting to go to scene: " + sceneName);
        SceneManager.LoadScene(sceneName);
    }

    public void ShowControls()
    {
        // TODO: Implement.
        // if not shown, disable menu stuff, show controls, vice versa
    }

    public void QuitGame()
    {
        Debug.Log("Ending the game.");
        Application.Quit();
    }

}
