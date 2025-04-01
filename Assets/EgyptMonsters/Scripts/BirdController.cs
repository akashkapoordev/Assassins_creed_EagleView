using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class BirdController : MonoBehaviour
{
    public float moveSpeed = 5f;
    public float turnSpeed = 100f;
    public float flapForce = 8f;

    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.useGravity = true;
    }

    void FixedUpdate()
    {
        Vector3 moveDirection = Vector3.zero;

        // Move Forward/Backward
        if (Input.GetKey(KeyCode.W))
        {
            moveDirection += transform.forward;
        }
        if (Input.GetKey(KeyCode.S))
        {
            moveDirection -= transform.forward;
        }

        // Apply movement
        rb.velocity = new Vector3(moveDirection.x * moveSpeed, rb.velocity.y, moveDirection.z * moveSpeed);

        // Turn Left/Right
        float turn = 0f;
        if (Input.GetKey(KeyCode.A))
        {
            turn = -1f;
        }
        else if (Input.GetKey(KeyCode.D))
        {
            turn = 1f;
        }
        transform.Rotate(0f, turn * turnSpeed * Time.fixedDeltaTime, 0f);

        // Flap Up
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.velocity = new Vector3(rb.velocity.x, 0f, rb.velocity.z); // reset Y
            rb.AddForce(Vector3.up * flapForce, ForceMode.VelocityChange);
        }
    }
}
