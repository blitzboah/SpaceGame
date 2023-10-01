using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AstDestroy : MonoBehaviour
{


    private void OnCollisionEnter(Collision col)
    {
        if(col.gameObject.CompareTag("Destroyer"))
        {
            Destroy(gameObject);

        }
    }
}
