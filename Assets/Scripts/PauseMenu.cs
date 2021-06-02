using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.Audio;

public class PauseMenu : MonoBehaviour
{
    public static bool GameIsPaused = false;
    public GameObject pauseMenuState;
    public AudioMixer audioMixer;
    [SerializeField] Slider volumeSlider;

    private void Start()
    {
        float volume = PlayerPrefs.GetFloat("volumesave");
        SetVolmue(volume);
        volumeSlider.value = volume;
    }


    // update to refere to functions
    void Update()
    {


        if (Input.GetKeyDown(KeyCode.Escape) )
        {
            if (GameIsPaused)
            {
                Resume();
            }
            else if (Time.timeScale != 0)
            {
                Pause();
            }
        }
    }
    // resume and pause function
    public void Resume()
    {
        pauseMenuState.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;
    }
    public void Pause()
    {
        pauseMenuState.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = true;
    }
    // menu and quit button functionality
    public void LoadMenu()
    {

        Time.timeScale = 1f;
        SceneManager.LoadScene("MenuScene");
        GameIsPaused = (false);
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    public void SetVolmue(float volume)
    {
        audioMixer.SetFloat("Volume", volume);
        PlayerPrefs.SetFloat("volumesave", volume);
    }
}
