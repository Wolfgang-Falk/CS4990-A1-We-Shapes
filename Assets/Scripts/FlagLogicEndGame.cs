using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlagLogicEndGame : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        GameObject.Find("GameController").GetComponent<GameControllerScript>().GameWin();
    }
}
