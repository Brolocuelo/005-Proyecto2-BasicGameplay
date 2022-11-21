using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 10f;
    public float xRange = 15f;

    public GameObject projectilePrefab;

    private float horizontalInput;
    //private float verticalInput;
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        //verticalInput = Input.GetAxis("Vertical");
        transform.Translate(Vector3.right * speed * Time.deltaTime * horizontalInput);
        //transform.Translate(Vector3.forward * speed * Time.deltaTime * verticalInput);
        PlayerInBounds();
        if (Input.GetKeyDown(KeyCode.Space))
        {
            FireProjectile();
        }
    }

    private void PlayerInBounds()
    {
        Vector3 pos = transform.position;

        if(pos.x < -xRange)
        {
            transform.position = new Vector3(-xRange,pos.y,pos.z);
        }
        if (pos.x > xRange)
        {
            transform.position = new Vector3(xRange, pos.y, pos.z);
        }
    }

    private void FireProjectile()
    {
        //(Que objecto queremos, Donde lo posicionamos y Con que rotacion); 
        Instantiate(projectilePrefab, transform.position, Quaternion.identity);
    }
}
