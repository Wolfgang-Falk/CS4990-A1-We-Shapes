using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameControllerScript : MonoBehaviour
{


    public int collectables = 0;
    public int collectablesAvailable = 0;

    public bool gameWon = false;

    public GameObject winCanvas;


    public void GameWin()
    {
        if (!gameWon)
        {
            gameWon = true;

            GameObject[] _players = GameObject.FindGameObjectsWithTag("Player");

            // Disable controls for all player objects.
            foreach (GameObject _player in _players)
            {
                _player.GetComponent<PlayerController>().playerInControl = false;
            }

            Instantiate(winCanvas);

        }
    }

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
