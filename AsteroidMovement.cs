using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidMovement : MonoBehaviour
{

    public float aSpeed = 10f;
    public float rSpeed;

    void Start()
    {
        
    }

    void Update()
    {
        
        aSpeed += 0.1f * Time.deltaTime;
        transform.position = transform.position + Vector3.left * aSpeed * Time.deltaTime;

        rSpeed = Random.Range(0f,20f);
        transform.Rotate(rSpeed * Time.deltaTime, rSpeed * Time.deltaTime, rSpeed * Time.deltaTime);
    }
}
