using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    // We want to use this to rotate the camera later.
    public Transform cameraTransform;
    private Rigidbody playerRigidbody;

    // Start is called before the first frame update
    void Start()
    {

        // Attempt to get the camera's transform if we don't already have it.
        if (cameraTransform == null)
        {
            Debug.LogWarning("Camera was not assigned, attempting to find it.");

            var _tempObject = GameObject.Find("Main Camera");

            if (_tempObject != null)
            {
                cameraTransform = _tempObject.transform;
                Debug.Log("Camera found and assigned.");
            }
            else
            {
                Debug.LogError("Unable to get the Camera!");
            }            
        }

        playerRigidbody = GetComponent<Rigidbody>();


    }

    // Update is called once per frame
    void Update()
    {

        // TODO: Player Movement

        // TODO: Shape Transformation

        // TODO: Collectibles

        // TODO: Camera Rotation based on collision with triggers.

    }
}
