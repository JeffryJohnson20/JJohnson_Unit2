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
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.A))
        {
            int animalPrefabInex = Random.Range(0, animalPrefabs.Length);
            float randXPos = Random.Range(-xPosRange, xPosRange);
            Vector3 randPos = new Vector3(randXPos, 0, 21);
            Instantiate(animalPrefabs[animalPrefabInex], randPos, 
                animalPrefabs[animalPrefabInex].transform.rotation);
        }
        

    }
}
