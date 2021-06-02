using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using UnityEngine.UI;
using UnityEngine.Audio;
public class MainMenu : MonoBehaviour
{
    public CameraFollow cameraFollow;
    public AudioMixer audioMixer;
    public AudioSource menusong;
    [SerializeField] Slider volumeSlider;


    public void Start()
    {
        
        
        float volume = PlayerPrefs.GetFloat("volumesave");
        SetVolmue(volume);
        volumeSlider.value = volume;
        menusong.Play();

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
    public void SetVolmue(float volume)
    {
        audioMixer.SetFloat("Volume", volume);
        PlayerPrefs.SetFloat("volumesave", volume);
    }


}
