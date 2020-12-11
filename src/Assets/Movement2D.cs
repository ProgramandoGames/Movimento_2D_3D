using UnityEngine;

public class Movement2D : MonoBehaviour {

    Vector2 targetVelocity;
    Vector2 currentVelocity;
    Vector2 velocity;

    public float maxSpeed     = 5;
    public float acceleration = 100f;

    void Start() {


    }

    void Update() {

        float horizontalInput = Input.GetAxisRaw("Horizontal");
        float verticalInput = Input.GetAxisRaw("Vertical");

        Vector2 direction = new Vector2(horizontalInput, verticalInput).normalized;

        velocity = Vector2.SmoothDamp(velocity, maxSpeed * direction, ref currentVelocity, maxSpeed / acceleration);

        transform.position += (Vector3)velocity * Time.deltaTime;

    }

}
