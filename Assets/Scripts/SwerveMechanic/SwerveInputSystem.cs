using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwerveInputSystem : MonoBehaviour
{
  
    private float lastFrameFingerPositionX;

    [HideInInspector]
    public float moveFactorX;
    [HideInInspector]
    public float MoveFactorX => moveFactorX;

    //The move limits left or right
    //Can be adjusted from the editor
    public float leftLimit;
    public float rightLimit;

    //Swerve movement is done on the x Axis
    Vector3 xPos;


    //Input Mouse Button
    //Works on mobile as touch

    void SwerveControl()
    {
        if (Input.GetMouseButtonDown(0))
        {
            lastFrameFingerPositionX = Input.mousePosition.x;
        }
        else if (Input.GetMouseButton(0))
        {
            moveFactorX = Input.mousePosition.x - lastFrameFingerPositionX;
            lastFrameFingerPositionX = Input.mousePosition.x;
        }
        else if (Input.GetMouseButtonUp(0))
        {
            moveFactorX = 0f;
        }
    }

    void SwerveMove()
    {
        xPos = new Vector3(Mathf.Clamp(transform.position.x, leftLimit, rightLimit), 0, 0);
        transform.position = new Vector3(xPos.x, transform.position.y, transform.position.z);
    }

    private void Update()
    {
        SwerveMove();
        SwerveControl();     
    }
}
