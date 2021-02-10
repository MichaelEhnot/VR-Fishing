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

    private static int fishCount;
    private int maxFishCount;



    
    
    // Start is called before the first frame update
    void Start()
    {
        fishCount = 1;
        maxFishCount = 5;
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
        Vector3 pos = new Vector3();
        pos.x = Random.Range(124, 168);
        pos.y = 24.83F;
        pos.z = Random.Range(22, 36);

        Instantiate(spawn_obj, pos, Quaternion.Euler(270,0,0));
        fishCount++;
    }

    private bool ShouldSpawn()
    {
        return (Time.time > nextSpawnTime && fishCount <= maxFishCount);
    }

    public static void DecrementFishCounter()
    {
        fishCount--;
    }
}
