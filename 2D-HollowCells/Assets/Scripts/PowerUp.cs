using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUp : MonoBehaviour
{

    public GameObject pickupEffect;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            Pickup();
        }
    }

    void Pickup()
    {

        Instantiate(pickupEffect, transform.position, transform.rotation);
        Destroy(gameObject);
    }
}
