using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectableScript : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        GameObject.Find("GameController").GetComponent<GameControllerScript>().collectables += 1;
        Destroy(gameObject);
    }

}
