using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement:MonoBehaviour {

    Rigidbody2D rgbd;
    public float movementSpeed, turnSpeed;
    float turnRotation;

    void Start() {
        rgbd = GetComponent<Rigidbody2D>();
    }

    void Update() {

        if(Input.GetKey(KeyCode.A)) {
            turnRotation += turnSpeed * Time.deltaTime;
        } else if(Input.GetKey(KeyCode.D)) {
            turnRotation -= turnSpeed * Time.deltaTime;
        }

        if(Input.GetKey(KeyCode.W)) {
            rgbd.velocity = transform.up * movementSpeed;
        }

        transform.rotation = Quaternion.Euler(0, 0, turnRotation);
    }
}
