using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] animalPrefabs; //Array de Animales
    public int animalIndex; //Indice del array de animales

    private float spawnRangeX = 14f;
    private float spawnPosZ = 15f;

    private float startDelay = 1.5f;
    private float spawnInterval = 2f;

    private void Start()
    {
        //Llama periodicamente a la funcion SpawnRandomAnimal
        InvokeRepeating("SpawnRandomAnimal",
            startDelay, spawnInterval);
    }
    //Hace aparecer un animal aleatorio en posicion X determinada
    private void SpawnRandomAnimal()
    {
        animalIndex = Random.Range(0, animalPrefabs.Length);
        Instantiate(animalPrefabs[animalIndex],
              RandomSpawnPos(),
              animalPrefabs[animalIndex].transform.rotation);
    }
    //Generamos un valor aleatoriamente para la pos en x
    private Vector3 RandomSpawnPos()
    {
        float randomX = Random.Range(-spawnRangeX, spawnRangeX);
        return new Vector3(randomX, 0, spawnPosZ); 
    }


}
