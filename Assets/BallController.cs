using UnityEngine;

public class BallController : MonoBehaviour
{
    public Rigidbody sphereRigidBody; // initializing the force component
    public float ballSpeed = 2f; // to see the ball speed

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log("Calling the Start method");
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 inputVector = Vector2.zero; // initialize the input vector
        if (Input.GetKey(KeyCode.W))
        {
            inputVector += Vector2.up;
        }

        if (Input.GetKey(KeyCode.S))
        {
            inputVector += Vector2.down;
        }

        if (Input.GetKey(KeyCode.D))
        {
            inputVector += Vector2.right;
        }

        if (Input.GetKey(KeyCode.A))
        {
            inputVector += Vector2.left;
        }

        Vector3 inputXZPlane = new Vector3(inputVector.x, 0, inputVector.y);
        sphereRigidBody.AddForce(inputXZPlane * ballSpeed);

        //Debug.Log("Resultant Vector: " + inputVector);
        //Debug.Log("Resultant 3D Vector: " + inputVector);
    }
}
