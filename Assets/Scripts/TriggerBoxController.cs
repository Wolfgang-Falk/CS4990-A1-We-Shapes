using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.GameCenter;

public class TriggerBoxController : MonoBehaviour
{

    GameObject playerChild;

    //switches player to a cirle
    private void OnTriggerEnter(Collider other)
    {
        
    other.GetComponent<BoxCollider>().enabled = false;

    Transform trans = other.transform;
    Transform childTrans = trans.Find("Shape - Cube");

        if (childTrans != null)
        {
            playerChild = childTrans.gameObject;
        }

        playerChild.GetComponent<MeshRenderer>().enabled = false;
    

    
    }
}

