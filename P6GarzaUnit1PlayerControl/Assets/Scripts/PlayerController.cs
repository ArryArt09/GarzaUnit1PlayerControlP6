using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float turnSpeed;
    public float driveSpeed;
    //Keep public for any issues within the controls
    private float horizontalInput;
    private float forwardInput;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        forwardInput = Input.GetAxis("Vertical");
        transform.Translate(Vector3.forward * Time.deltaTime * driveSpeed * forwardInput);
        //code for driving the car
        horizontalInput = Input.GetAxis("Horizontal");
        transform.Rotate(Vector3.up * Time.deltaTime * turnSpeed * horizontalInput);
        //code for turning the car
    }
}
