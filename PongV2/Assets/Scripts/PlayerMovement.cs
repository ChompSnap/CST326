using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float movementPerSecond = 1f;
    public bool isPlayer1;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float movementAxis;
        if (isPlayer1)
        {
            movementAxis = Input.GetAxis("Vertical");
        }
        else
        {
            movementAxis = Input.GetAxis("Vertical2");
        }
        Rigidbody rbody = GetComponent<Rigidbody>();

        Vector3 force = Vector3.forward * movementAxis * movementPerSecond * Time.deltaTime;

        rbody.AddForce(force, ForceMode.VelocityChange);

        //Transform transform = GetComponent<Transform>();
        //transform.position += Vector3.forward * movementAxis * movementPerSecond * Time.deltaTime;
        /*
        if(Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector3.forward * Time.deltaTime * movementPerSecond);
            Debug.Log("Test");
        }
        if(Input.GetKey(KeyCode.S))
        {
            transform.Translate(Vector3.back * Time.deltaTime * movementPerSecond);
        }
        */
    }
    /*private void OnCollisionEnter(Collision collision)
    {
        BoxCollider bbox = GetComponent<BoxCollider>();
        float xCenter = bbox.bounds.center.x;

        Debug.Log("Center at " + xCenter + " collided object at " + collision.transform.position.x);

        Vector3 newVector = Quaternion.Euler(45f, 0f, 45f) * Vector3.left;
        Debug.DrawLine(transform.position, transform.position + newVector * 10f, Color.white);
        Debug.Break();

    }*/
}
