using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets._2D;

public class PowerUp : MonoBehaviour
{
    public GameObject pickupEffect;

    public float speedBoost = 1.5f;
    //public float powerupTime = 5f;

    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.CompareTag("Player"))
        {
            StartCoroutine(Pickup(collision));
        }
    }

    IEnumerator Pickup(Collider2D player)
    {
        // spawn effect
        Instantiate(pickupEffect, transform.position, transform.rotation);

        
        PlatformerCharacter2D speed = player.GetComponent<PlatformerCharacter2D>();
        speed.m_MaxSpeed *= speedBoost;

        GetComponent<SpriteRenderer>().enabled = false; // disable Sprite
        GetComponent<Collider2D>().enabled = false; // disable collider

        yield return new WaitForSeconds(10f); // wait for 10s

        speed.m_MaxSpeed /= speedBoost;

        Destroy(gameObject);
    }

    
}
