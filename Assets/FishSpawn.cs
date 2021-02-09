 using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * Code from: https://www.youtube.com/watch?v=9KOHclqSmR4
 */
public class FishSpawn : MonoBehaviour
{
    private float nextSpawnTime = 0;
    [SerializeField]
    private GameObject spawn_obj;
    [SerializeField]
    private float spawnDelay = 20;


    
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (ShouldSpawn())
        {
            Spawn();
        }
    }

    private void Spawn()
    {
        nextSpawnTime = Time.time + spawnDelay;
        Instantiate(spawn_obj, transform.position, transform.rotation);
        print("spawn");
    }

    private bool ShouldSpawn()
    {
        return Time.time > nextSpawnTime;
    }
}
