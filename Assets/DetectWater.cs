using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectWater : MonoBehaviour

{
    private Vector3 startPos;

    // Start is called before the first frame update
    void Start()
    {
        startPos = new Vector3(
            gameObject.transform.position.x,
            31,
            gameObject.transform.position.z
            );
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.tag == "Water")
        {
            gameObject.transform.position = new Vector3(175, 31, 51);
        }
    }
}
