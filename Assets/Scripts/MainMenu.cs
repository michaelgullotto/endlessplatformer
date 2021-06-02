using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

public class MainMenu : MonoBehaviour
{
    public CameraFollow cameraFollow;

    public void Start()
    {
        
        Screen.SetResolution(412, 732, Screen.fullScreen);

        Save save = cameraFollow.LoadGame();
        Scoresave.Highscore = save.SavedScore;

    }
    public void Playgame()
    {
        // load scene from main menu
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void Quitgame()
    {
        // quits game from main menu
        Debug.Log("quit");
        Application.Quit();

    }


}
