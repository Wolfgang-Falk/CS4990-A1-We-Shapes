using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorLogicTutorial : MonoBehaviour
{

    public GameObject gameController;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Check to make sure score is at the correct value to continue
        if(gameController.GetComponent<GameControllerScript>().collectables == 1)
        {
            Destroy(gameObject);
        }

    }
}
