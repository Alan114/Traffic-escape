using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] enemiesPrefabs;
    private float xRange = 18.0f;    
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnEnemy", 1, 1); 
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnEnemy()
    {
        float randomX = Random.Range(-xRange, xRange);
        int randomIndex = Random.Range(0, enemiesPrefabs.Length);
        Instantiate(enemiesPrefabs[randomIndex], new Vector3(randomX, 1, 17), enemiesPrefabs[randomIndex].gameObject.transform.rotation);
    }
}
