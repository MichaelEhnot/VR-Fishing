using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class FishCaught : MonoBehaviour
{
    private TextMeshPro txt;
    private static int fishCaught;
    
    
    // Start is called before the first frame update
    void Start()
    {
        txt = (TextMeshPro)gameObject.GetComponent(typeof(TextMeshPro));
        fishCaught = 0;
    }

    // Update is called once per frame
    void Update()
    {
        txt.text = "Fish Caught\n"+fishCaught.ToString();
    }

    public static void IncrementFishCaught()
    {
        fishCaught++;
    }
}
