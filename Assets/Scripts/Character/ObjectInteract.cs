using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectInteract : MonoBehaviour
{
    Inventory inventario;
    void Start()
    {
        inventario = GameObject.FindGameObjectWithTag("Player").GetComponent<Inventory>();
    }

    private void OnTriggerEnter(Collider other)

    {
        if (other.tag == "Player")
        {
            inventario.Cantidad = inventario.Cantidad + 1;
            Destroy(gameObject);
        }

    }
}
