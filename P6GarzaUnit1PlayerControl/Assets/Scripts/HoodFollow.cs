using UnityEngine;

public class HoodFollow : MonoBehaviour
{

    public GameObject player;
    private Vector3 offset = new Vector3(0, 2, 0);

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //transform.position = player.transform.position + offset;
    }

    void LateUpdate()
    {
        transform.position = player.transform.position + offset;
        transform.position = player.transform.position + player.transform.TransformDirection(offset);
        transform.rotation = player.transform.rotation;
    }
}