using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float turnSpeed;
    public float driveSpeed;
    public float speed = 20.0f;
    public float horizontalInput;
    public float forwardInput;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");

        //The videos take so long for things that I already know what to do
        //I'm leaving a comment because this is what makes the car move forward
        transform.Translate(Vector3.forward * Time.deltaTime * driveSpeed * forwardInput);
        transform.Translate(Vector3.right * Time.deltaTime * turnSpeed * horizontalInput);
    }
}
