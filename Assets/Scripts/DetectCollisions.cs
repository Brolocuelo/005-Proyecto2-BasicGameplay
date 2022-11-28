using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollisions : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        Destroy(gameObject);//Destruye el propio objecto
        Destroy(other.gameObject);//Destruye al objecto que colisiona;
    }
}
