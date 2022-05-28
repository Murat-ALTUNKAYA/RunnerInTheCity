using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleController : MonoBehaviour
{
    private float speed = 20f;
    private PlayerController playerControllerScript;
    private float leftBound = -10f;


    private void Start()
    {
        playerControllerScript = GameObject.Find("Player").GetComponent<PlayerController>();
    }
    private void Update()
    {
        if (playerControllerScript.gameOver == false)
        {
            ObstacleMove();
            DestroyObj();
        }
    }
    private void ObstacleMove()
    {
        transform.Translate(Vector3.left * speed * Time.deltaTime);
    }
    private void DestroyObj()
    {
        if (transform.position.x < leftBound && gameObject.CompareTag("Obstacle"))
        {
            Destroy(gameObject);
        }
    }
}
