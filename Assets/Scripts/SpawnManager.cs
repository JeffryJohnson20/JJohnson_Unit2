using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] animalPrefabs;
    private float xPosRange = 13.0f;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandomAnimal", 3.0f, 1.5f);
    }

    // Update is called once per frame
    void Update()
    {
    }

    void SpawnRandomAnimal()
    {
        int animalPrefabInex = Random.Range(0, animalPrefabs.Length);
        float randXPos = Random.Range(-xPosRange, xPosRange);
        Vector3 randPos = new Vector3(randXPos, 0, 21);
        Instantiate(animalPrefabs[animalPrefabInex], randPos,
            animalPrefabs[animalPrefabInex].transform.rotation);
    }
}
