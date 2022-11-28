using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBound : MonoBehaviour
{
    private float upperLimit = 30f;
    private float lowerLimit = -10f;

    void Update()
    {
        //Limite Inferior -> Animales No Alimentados
        if(transform.position.z < lowerLimit)
        {
            Destroy(gameObject);
            Debug.Log("GAME OVER");
            Time.timeScale = 0;
        }
        //Limite Superior -> Bala Fallida
        if (transform.position.z > upperLimit)
        {
            Destroy(gameObject);
        }
    }
}
