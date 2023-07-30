using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public float runSpeed = 7;
    public float rotationSpeed = 250;
    public CharacterController controller;
    public Animator animator;
    public AudioSource pasos;
    private bool Vactivo;

    private float x, y;

    void Update()
    {
        x = Input.GetAxis("Horizontal");
        y = Input.GetAxis("Vertical");

        Vector3 movimiento = new Vector3(x, 0, y);
        float magnitudMovimiento = movimiento.magnitude;

        transform.Rotate(0, x * Time.deltaTime * rotationSpeed, 0);
        transform.Translate(0, 0, y * Time.deltaTime * runSpeed);

        animator.SetFloat("VelX", x);
        animator.SetFloat("VelY", y);

        if (magnitudMovimiento > 0 && !Vactivo)
        {
            Vactivo = true;
            pasos.Play();
        }
        else if (magnitudMovimiento == 0 && Vactivo)
        {
            Vactivo = false;
            pasos.Stop();
        }
    }
}