using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLeft : MonoBehaviour
{
    private float speed = 10f;
    private void Update() 
    {
        LeftMove();
    }
    private void LeftMove()
    {
        transform.Translate(Vector3.left * speed * Time.deltaTime);
    }
}