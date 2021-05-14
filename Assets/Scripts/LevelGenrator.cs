using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelGenrator : MonoBehaviour
{
    public int roll;
    public GameObject player;
    public GameObject platformPrefab;
    public GameObject jumpPlatformPrefab;
    public GameObject launchPadPrefab;
    public int intialspawn = 20;
    void Start()
    {
        Vector3 spawnPostition = new Vector3();

        for (int i = 0; i < intialspawn; i++)
        {

            spawnPostition.y += Random.Range(.5f, 1f);
            spawnPostition.x = Random.Range(-3f, 3f);
            Instantiate(platformPrefab, spawnPostition, Quaternion.identity);

        }
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        Destroy(collision.gameObject);

        roll = Random.Range(1, 1000); 
        if (roll <= 900)
        {
            Instantiate(platformPrefab, new Vector2(Random.Range(-3f, 3f), player.transform.position.y + (14 + Random.Range(0.5f, 1f))), Quaternion.identity);
        }
        else if (roll > 900 && roll < 980)
        {
            Instantiate(jumpPlatformPrefab, new Vector2(Random.Range(-3f, 3f), player.transform.position.y + (14 + Random.Range(0.5f, 1f))), Quaternion.identity);
        }
        else if (roll > 980 && roll <= 1000)
        {
            Instantiate(launchPadPrefab, new Vector2(Random.Range(-3f, 3f), player.transform.position.y + (14 + Random.Range(0.5f, 1f))), Quaternion.identity);
        }
       
    }

    

}

