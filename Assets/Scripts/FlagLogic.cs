using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlagLogic : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        GameObject.Find("GameController").GetComponent<GameControllerScript>().GameWin();
    }
}
