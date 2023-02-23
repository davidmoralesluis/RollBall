using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController2 : MonoBehaviour
{
    public float speed = 5;

    public String saludo = "Hola";

    private Rigidbody rb;

    public float movementX;
    public float movementY;

    // Start is called before the first frame update
    void Start()
    {
        // instanciando el objeto que contiene este script
        // la bola
        rb = GetComponent<Rigidbody>();
        // mensaje para la consola del Unity
        Debug.Log("Estoy en Start ");
    }

    /**
     *  Evento Input System
     **/
    private void OnMove(InputValue movementValue)
    {
        Vector2 movementVector = movementValue.Get<Vector2>();

        movementX = movementVector.x;
        movementY = movementVector.y;
        // mensaje para la consola del Unity
        Debug.Log("Estoy en OnMove ,Y -> "+movementY+" ,x -> "+movementX);
    }

    private void FixedUpdate()
    {
        // para el teclado
        Vector3 movement = new Vector3( movementX, 0.0f, movementY);
        rb.AddForce(movement * speed);
        

        // recogemos los datos del acelerometro
        // Vector3 dir = Vector3.zero;
        // dir.x = -Input.acceleration.y;
        // dir.z = Input.acceleration.x;
        // if (dir.sqrMagnitude > 1)
        //     dir.Normalize();
        //
        // dir *= Time.deltaTime;
        // transform.Translate(dir * speed);
    }

}

