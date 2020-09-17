using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameControllerScript : MonoBehaviour
{


    public int collectables = 0;
    public int collectablesAvailable = 0;

    // Start is called before the first frame update
    void Start()
    {
        // We don't need to know anything about the collectables, just how many there are.
        collectablesAvailable = GameObject.FindGameObjectsWithTag("Collectable").Length;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
