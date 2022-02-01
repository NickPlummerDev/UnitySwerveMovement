using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelEnd : MonoBehaviour
{
    [Header("LevelSettings")]
    public float destroyTime;
    public bool destroy;
    public GameObject mainBlock;
 


    void Update()
    {
        if(destroy == true)
        {
            Destroy(mainBlock, destroyTime);
        }
    }
}
