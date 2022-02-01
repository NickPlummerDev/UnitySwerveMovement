using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelGenerateCaller : MonoBehaviour
{

    //Place this on player to spawn new levels

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "LevelSpawn")
        {
            GenerationManager levelGenerate =
                other.gameObject.GetComponent<GenerationManager>();
            levelGenerate.SpawnLevel();
        }
        if(other.gameObject.tag == "LevelEnd")
        {
            LevelEnd levelEnd =
                other.gameObject.GetComponent<LevelEnd>();
            levelEnd.destroy = true;
        }
    }

 
}
