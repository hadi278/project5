using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnObject : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject[] animalprebaps;
    private float spawnRangex = 20;
    private float spawnPos2 =20;
    private float StartDelay = 2;
    private float spawnInterval = 1.5f;

    void Start()
    {
        InvokeRepeating("RandomAnimalSpawn", StartDelay, spawnInterval);
    }   

    // Update is called once per frame
    void Update()
    {

    }

    void RandomAnimalSpawn(){
        Vector3 spawnPos = new Vector3 (Random.Range(-spawnRangex, spawnRangex),0,spawnPos2);
        int animalIndex = Random.Range(0, animalprebaps.Length);
        Instantiate(animalprebaps[animalIndex],spawnPos, animalprebaps[animalIndex].transform.transform.rotation);

    }
}
