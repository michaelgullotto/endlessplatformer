using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

public class CameraFollow : MonoBehaviour
{
    public GameObject gameOverCanvas;
    public Transform target;
    
    

    public void Start()
    {
        Screen.SetResolution(412, 732, Screen.fullScreen);
        Save save = LoadGame();
        Scoresave.Highscore = save.SavedScore;

        Time.timeScale = 1;
    }
    void LateUpdate()
    {
        
        // tells cam to follow player but only allows upwards movement
        if (target.position.y > transform.position.y)
        {
            Vector3 newPos = new Vector3(transform.position.x, target.position.y, transform.position.z);
            transform.position = newPos;
           
            Player player = target.GetComponent<Player>();
            float distance = 0;

            // calulates distance from start postion for score and updates it for the score text script
            if (player != null)
            {
                distance = player.transform.position.y - player.startPosition.y;
            }
            if (distance > Scoresave.score)
            {
                Scoresave.score++;
            }
        }
        //kills player if they fall out of screen
        else if (target.position.y < transform.position.y - 5 && Time.timeScale != 0)
        {
            GameOver();
            
        }

    }

    public void GameOver()
    {

        
        gameOverCanvas.SetActive(true);
        Time.timeScale = 0;
        SaveGame(Scoresave.Highscore);

    }

    public void Restart()
    {
        SceneManager.LoadScene(1);
    }

    public void SaveGame(int score)
    {
        Save save = new Save(score);
       
        BinaryFormatter bf = new BinaryFormatter();
        FileStream file = File.Create(Application.persistentDataPath + "/gamesave.save");
        bf.Serialize(file, save);
        file.Close();

       



        Debug.Log("Game Saved");
    }
    public Save LoadGame()
    {
        if (File.Exists(Application.persistentDataPath + "/gamesave.save"))
        {
            BinaryFormatter bf = new BinaryFormatter();
            FileStream file = File.Open(Application.persistentDataPath + "/gamesave.save",
                FileMode.Open);
            Save save = (Save)bf.Deserialize(file);
            file.Close();


            return save;// Scoresave.Highscore = Save.SavedScore;


        }

        return null;
    }
}

