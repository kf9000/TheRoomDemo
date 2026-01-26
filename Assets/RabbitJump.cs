using System;
using UnityEngine;

public class RabbitJump : MonoBehaviour
{
    public GameObject rabbit;
    public float maxJumpHeight = 1.0f;

    private  float jumpHeight = 0.0f;
    private bool isGoingup = true;
    public float degreesPerSecond = 50.0f;
    public float jumpSpeed = 0.01f;


    void Update()
    {
        if(jumpHeight >= maxJumpHeight)
        {
            isGoingup = false;
        }
        if(jumpHeight <= 0)
        {
            isGoingup = true;
        }
        if (isGoingup)
        {
            jumpHeight += jumpSpeed;
        }
        else
        {
            jumpHeight -= jumpSpeed;
        }
        rabbit.transform.position = new Vector3(rabbit.transform.position.x, jumpHeight, rabbit.transform.position.z);
        rabbit.transform.Rotate(0, degreesPerSecond * Time.deltaTime, 0);


    }
}
