using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerOneMovement : MonoBehaviour
{
    private Rigidbody playerRigidBody;

    private Vector3 inputVector;

    private float inputx;
    private float inputz;
    public float speed = 10f;
    public int playerScore = 0;


    // Start is called before the first frame update
    void Start()
    {
        playerRigidBody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        inputVector = new Vector3(Input.GetAxis("Horizontal")*speed, playerRigidBody.velocity.y, Input.GetAxis("Vertical")*speed);
        playerRigidBody.velocity = inputVector;


    }
}
