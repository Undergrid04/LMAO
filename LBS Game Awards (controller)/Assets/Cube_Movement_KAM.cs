using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class Cube_Movement_KAM : MonoBehaviour
{
    // Start is called before the first frame update

   
    public Rigidbody rb;
    void Start()
    {
         
    }

    public float forwardForce = 2000f;
    // Update is called once per frame
    void FixedUpdate() // Jag skrev FixedUpdate så att jag kan leka runt med fysikenslagar lättare=)
    {   
        {
            rb.AddForce(0 * Time.deltaTime, 0, 0);

            if (Input.GetKey("d"))
            {
                rb.AddForce(500 * Time.deltaTime, 0, 0);
            }

            if (Input.GetKey("w"))
            {
                rb.AddForce(0, 0, 500 * Time.deltaTime);
            }

            if (Input.GetKey("a")) 
            {
                rb.AddForce(-500 * Time.deltaTime, 0, 0);
            }

            if (Input.GetKey("s"))
            {
                rb.AddForce(0, 0, -500 * Time.deltaTime);
            }

        }
    }
}
