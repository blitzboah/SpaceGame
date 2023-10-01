using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    float yInput;
    float speed = 10f;
    float rotSpeed = 150f;
    public GameObject astspwn;


    void Start()
    {
        
    }

    void Update()
    {
        

        yInput = Input.GetAxis("Vertical"); 
        transform.position = transform.position + new Vector3(0 , yInput * speed * Time.deltaTime , 0);

        if(Input.GetKey(KeyCode.W)|| Input.GetKey(KeyCode.UpArrow))
        {
            transform.Rotate(Vector3.up * rotSpeed * Time.deltaTime);

        }

        if(Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow))
        {
            transform.Rotate(Vector3.down * rotSpeed * Time.deltaTime);

        }

        if(transform.position.y > 10 || transform.position.y < -10)
        {
            Destroy(gameObject);
            Destroy(astspwn);
        }

    }

    private void OnCollisionEnter(Collision player)
    {
        if(player.gameObject.CompareTag("Asteroid"))
        {
            Destroy(gameObject);
            Destroy(astspwn);

        }
    }
}
