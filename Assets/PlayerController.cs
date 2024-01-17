using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    Rigidbody playerBody;
    public float speed = 1000;

    // Start is called before the first frame update
    void Start()
    {
        playerBody = GetComponent<Rigidbody>();
    }

    // Update the movement of the player
    void FixedUpdate()
    {
        Vector3 movement = new Vector3(Input.GetAxis("Horizontal"), 0f, Input.GetAxis("Vertical"));

        playerBody.AddForce(movement * Time.deltaTime * speed);
    }
}