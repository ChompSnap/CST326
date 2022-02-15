using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUp : MonoBehaviour
{ 
    public float direction;

    // Update is called once per frame
    void Update()
    {
        transform.Translate(new Vector3(0, 0, direction) * Time.deltaTime);
        Debug.Log(transform.position.z);
        if (transform.position.z >= 5 || transform.position.z <= -5)
        {
            direction *= -1;
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name != "Ball")
        {
            direction *= -1;
        }
        
    }
}
