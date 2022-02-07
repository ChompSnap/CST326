using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public float speed;
    public Rigidbody rbody;
    private Vector3 direction;
    private int counter = 0;
    public Material material;


    // Start is called before the first frame update
    void Start()
    {
        Launch();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void Launch()
    {
        float x = Random.value < 0.5f ? -1.0f : 1.0f;
        float z = Random.value < 0.5f ? Random.Range(-1.0f, -0.5f) : Random.Range(0.5f, 1.0f);

        direction = new Vector3(x, 0, z);
        rbody.AddForce(direction * this.speed);
    }

    public void AddForce(Vector3 force)
    {
        rbody.AddForce(force);
    }

    private void OnCollisionEnter(Collision collision)
    {
        Vector3 normal = collision.contacts[0].normal;
        direction = Vector3.Reflect(direction, normal);
        rbody.AddForce(direction * this.speed);

        counter++;
        if (counter == 1)
        {
            material.color = Color.red;
        }
        else if(counter == 2)
        {
            material.color = Color.green;
        }
        else if(counter == 3)
        {
            material.color = Color.blue;
        }
        else
        {
            material.color = Color.white;
            counter = 0;
        }
    }

    public void ResetPostion()
    {
        rbody.position = Vector3.zero;
        rbody.velocity = Vector3.zero;
        Launch();
    }
}
