using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBound : MonoBehaviour
{
    public float upperLimit = 30f;
    public float lowerLimit = -10f;

    void Update()
    {
        //Limite Inferior -> Animales No Alimentados
        if(transform.position.z < lowerLimit)
        {
            Destroy(gameObject);
        }
        //Limite Superior -> Bala Fallida
        if (transform.position.z > upperLimit)
        {
            Destroy(gameObject);
        }
    }
}
