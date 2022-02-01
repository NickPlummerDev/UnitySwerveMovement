using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerationManager : MonoBehaviour
{
    //Tags needed to work
    //LevelSpawn
    //LevelEnd
    [Header("Level Blocks")]
    public GameObject[] levelBlocks;

    [Header("LevelSettings")]
    int randomSpawn;
    private bool spawned;
    public Transform endPoint;


    public void SpawnLevel()
    {
        randomSpawn = Random.Range(0, levelBlocks.Length);
        if (spawned == false)
        {
            GameObject map = Instantiate(levelBlocks[randomSpawn], endPoint.position, endPoint.rotation); 
            map.name = "Map" + randomSpawn;

            //Instantiate(levelBlocks[randomSpawn], endPoint.position, endPoint.rotation);
            spawned = true;
        }
    }

}
