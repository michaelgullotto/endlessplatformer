using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;


public class Scoresave : MonoBehaviour
{
    static public int score = 0 ;
     static public int Highscore = 0 ;
    
    void Start()
    {
        
        score = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (score > Highscore)
        {
            Highscore = score;
        }
    }

    //private Save CreateSave()
    //{
    //    Save save = new Save();

    //    Save.SavedScore = Highscore;

    //    return save;

    //}

    //public void SaveGame()
    //{
    //    Save save = CreateSave();

    //    BinaryFormatter bf = new BinaryFormatter();
    //    FileStream file = File.Create(Application.persistentDataPath + "/gamesave.save");
    //    bf.Serialize(file, save);
    //    file.Close();

    //    Save.SavedScore = Highscore;

        

    //    Debug.Log("Game Saved");
    //}

    //public void LoadGame()
    //{
    //    if (File.Exists(Application.persistentDataPath + "/gamesave.save"))
    //    {
    //        BinaryFormatter bf = new BinaryFormatter();
    //        FileStream file = File.Open(Application.persistentDataPath + "/gamesave.save",
    //            FileMode.Open);
    //        Save save = (Save)bf.Deserialize(file);
    //        file.Close();


    //        Highscore = Save.SavedScore;


    //    }
    //}



}
