using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fish : MonoBehaviour
{
    private float direction;
    private float speed;

    // Start is called before the first frame update
    void Start()
    {
        direction = Random.Range(0, 2*Mathf.PI);
        speed = 0.05f;
    }

    // Update is called once per frame
    void Update()
    {
        gameObject.transform.position = new Vector3(
            Mathf.Sin(direction)*(speed) + gameObject.transform.position.x,
            gameObject.transform.position.y,
            Mathf.Cos(direction)*(speed) + gameObject.transform.position.z
            );
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Lure")
        {
            Destroy(gameObject);
        }

        if(collision.gameObject.tag == "Terrain")
        {
            //direction = Random.Range(0, 2 * Mathf.PI);
            direction = -direction;
        }
    }
}
