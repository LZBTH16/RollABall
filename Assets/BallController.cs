using UnityEngine;

public class BallController : MonoBehaviour
{
    [SerializeField] private Rigidbody sphereRigidBody; // initializing the force component
    [SerializeField] private float ballSpeed = 2f; // to see the ball speed
    // setting up jump capability
    [SerializeField] private float jumpForce = 0.75f;
    private bool isGrounded;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        sphereRigidBody = GetComponent<Rigidbody>();
    }

    private void OnCollisionStay()
    {
        isGrounded = true;
    }

    public void MoveBall (Vector2 input)
    {
        Vector3 inputXZPlane = new(input.x, 0, input.y);
        sphereRigidBody.AddForce (inputXZPlane * ballSpeed);

        // making it jump
        if (Input.GetKey(KeyCode.Space) && isGrounded)
        {
            sphereRigidBody.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            isGrounded = false;

        }
    }
}
