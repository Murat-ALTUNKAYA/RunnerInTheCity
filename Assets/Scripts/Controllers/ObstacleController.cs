using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleController : MonoBehaviour
{
    private float speed = 10f;
    private PlayerController playerControllerScript;


    private void Start() 
    {
        playerControllerScript = GameObject.Find("Player").GetComponent<PlayerController>();
    }
    private void Update() 
    {
        if (playerControllerScript.gameOver == false)
        {
            ObstacleMove();
        }
    }
    private void ObstacleMove()
    {
        transform.Translate(Vector3.left * speed * Time.deltaTime);
    }
}
