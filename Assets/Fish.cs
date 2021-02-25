using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fish : MonoBehaviour
{
    private float direction;
    private float speed;
    private float nextDirectionChange;
    private float changeDirectionDelay;
    private AudioSource spash;


    // Start is called before the first frame update
    void Start()
    {
        direction = Random.Range(0, 2*Mathf.PI);
        speed = 0.015f;
        changeDirectionDelay = 5;
        spash = (AudioSource)gameObject.GetComponent(typeof(AudioSource));
    }

    // Update is called once per frame
    void Update()
    {
        if(Time.time > nextDirectionChange)
        {
            direction = Random.Range(0, 2 * Mathf.PI);
            gameObject.transform.rotation = Quaternion.Euler(270, ((Mathf.Rad2Deg*direction)+270)%360, 0);
            nextDirectionChange += changeDirectionDelay;
        }
        
        gameObject.transform.position = new Vector3(
            Mathf.Sin(direction)*(speed) + gameObject.transform.position.x,
            gameObject.transform.position.y,
            Mathf.Cos(direction)*(speed) + gameObject.transform.position.z
            );
    }

    private void OnTriggerEnter(Collider other)
    { 
        if(other.gameObject.tag == "Lure")
        {
            spash.Play();
            Destroy(gameObject, 1);
            FishSpawn.DecrementFishCounter();
            FishCaught.IncrementFishCaught();
        }
    }

    private void OnTriggerStay(Collider other)
    {
        if(other.gameObject.tag == "Terrain")
        {
            gameObject.transform.position = new Vector3(
                Random.Range(124,168),
                24.83f,
                Random.Range(22,36)
                );
        }
    }
}
