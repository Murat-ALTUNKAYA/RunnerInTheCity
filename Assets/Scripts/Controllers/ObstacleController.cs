using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleController : MonoBehaviour
{
    private float speed = 10f;
    private void Update() 
    {
        ObstacleMove();
    }
    private void ObstacleMove()
    {
        transform.Translate(Vector3.left * speed * Time.deltaTime);
    }
}
