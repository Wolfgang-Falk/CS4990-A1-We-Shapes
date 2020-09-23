using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HiddenRampController : MonoBehaviour
{

    public GameObject collectable; 


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //brings ramp into existance when the collectable is gone
        if(collectable == null)
        {
            gameObject.GetComponent<BoxCollider>().enabled = true;
            gameObject.GetComponent<MeshRenderer>().enabled = true;
        }
    }
}
