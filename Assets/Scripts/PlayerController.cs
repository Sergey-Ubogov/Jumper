using UnityEngine;

public class PlayerController : MonoBehaviour
{   
    public float velocity = 5;
    private Rigidbody rb;
    private GroundedController groundedController;
    void Awake() {
        rb = GetComponent<Rigidbody>();
        groundedController = GetComponent<GroundedController>();
    }
    void Update()
    {
        handleKeyboard();
    }

    private void handleKeyboard() {
        handleJump();
        handleHorizontalMove();
    }
    private void handleJump() {
        if (Input.GetButton("Jump") && groundedController.isGrounded) {
            rb.velocity = Vector3.up * velocity;
        }
    }
    private void handleHorizontalMove() {
        Vector3 moveDir = Vector3.zero;
        moveDir.x = Input.GetAxis("Horizontal");
        transform.position += moveDir * velocity * Time.deltaTime;
    }
}
