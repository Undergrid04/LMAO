using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{
    public Transform playercam;

    void Awake()
    {
        playercam = Camera.main.transform;
    }
    public Rigidbody rb;
    void Start()
    {

    }

    public float forwardForce = 2000f;
    // Update is called once per frame
    void FixedUpdate() // Jag skrev FixedUpdate så att jag kan leka runt med fysikenslagar lättare=)
    {
        rb.AddForce(0, 0, forwardForce * Time.deltaTime);

        if (Input.GetKey("d"))
        {
            rb.AddForce(500 * Time.deltaTime, 0, 0);
        }
    }
}
