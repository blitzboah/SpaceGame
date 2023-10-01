using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkyBox : MonoBehaviour
{

    public float SkySpeed;
    void Start()
    {
        
    }

    void Update()
    {
        RenderSettings.skybox.SetFloat("_Rotation", SkySpeed * Time.time);
    }
}
