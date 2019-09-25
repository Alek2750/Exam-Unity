using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets._2D;

public class Fireball : MonoBehaviour
{
    [SerializeField] private int damageAmount;

    public int health = 100;
    private PlatformerCharacter2D player;
    public GameObject deathEffect;
    public float speed;
    public Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        player = FindObjectOfType<PlatformerCharacter2D>();

        rb = GetComponent<Rigidbody2D>();

        if (player.transform.position.x < transform.position.x)
        {
            speed = -speed;
        }
    }

    // Update is called once per frame
    void Update()
    {
        rb.velocity = new Vector2(speed, rb.velocity.y);
    }

    

    public void OnTriggerEnter2D(Collider2D collider)
    {
        Player player = collider.GetComponent<Player>();
        if (collider.CompareTag("Player"))
        {

            player.DamageTake(damageAmount);
        }
        Instantiate(deathEffect, transform.position, transform.rotation);
        
        Destroy(gameObject);
    }

}
