using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class cube : MonoBehaviour
{
    Playercontrols controls;
    // Start is called before the first frame update

    public Transform playercam; 
        
    Vector2 move;
    Vector2 rotate;
    Vector2 jump;

    
    
    void Awake()
    {
        playercam = Camera.main.transform;

        controls = new Playercontrols();

        controls.Gameplay.Move.performed += ctx => move = ctx.ReadValue<Vector2>();

        controls.Gameplay.Move.canceled += ctx => move = Vector2.zero;

        controls.Gameplay.Rotate.performed += ctx => rotate = ctx.ReadValue<Vector2>();

        controls.Gameplay.Rotate.canceled += ctx => rotate = ctx.ReadValue<Vector2>();

        controls.Gameplay.Jump.performed += ctx => jump = ctx.ReadValue<Vector2>();

        controls.Gameplay.Jump.canceled += ctx => jump = ctx.ReadValue<Vector2>();
    }
    void Grow()
    {
        transform.localScale *= 1.1f;
    }

    void Update()
    {
        //Vector2 m = new Vector2(-move.x, move.y) *15 * Time.deltaTime;

        Vector2 m = transform.right * -move.x + transform.forward * move.y;
        transform.Translate(m);

        m *= 15 * Time.deltaTime;
        
        Vector2 r = new Vector2(-rotate.y, rotate.x) *300 * Time.deltaTime;
        transform.Rotate(r, Space.World);

        
    }


     void OnEnable()
    {
        controls.Gameplay.Enable();
    }

     void OnDisable()
    {
        controls.Gameplay.Disable();
    }



}

