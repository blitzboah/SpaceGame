using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidSpawner : MonoBehaviour
{
    public GameObject[] Asteroid;
    float rSpeed;

    public float spawnRate = 2f;

    void Start()
    {
        InvokeRepeating("Spawn", 5f , spawnRate);
    }

    private void Spawn()
    {
        rSpeed = Random.Range(0f,20f);

        var spawnPoint1 = new Vector3(25, Random.Range(0f,10f), 15);
        var spawnPoint2 = new Vector3(25, Random.Range(-10f,0f), 15);

        Instantiate(Asteroid[0], spawnPoint1, Quaternion.identity);
        Instantiate(Asteroid[1], spawnPoint2, Quaternion.identity);

    }
}
