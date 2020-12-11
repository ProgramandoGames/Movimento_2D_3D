using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement3D : MonoBehaviour {

    Vector3 velocity;
    Vector3 direction = Vector3.zero;
    Vector3 currentVelocity;

    public float acceleration = 50;
    public float maxSpeed     = 10;


    void Start() {
    
        
    }


    void Update() {

        float horizontalInput = Input.GetAxisRaw("Horizontal");
        float verticalInput   = Input.GetAxisRaw("Vertical");

        direction = new Vector3(horizontalInput, 0, verticalInput).normalized;


        velocity = Vector3.SmoothDamp(velocity, direction * maxSpeed, ref currentVelocity, maxSpeed / acceleration);


        transform.position += velocity * Time.deltaTime;

    }

}
