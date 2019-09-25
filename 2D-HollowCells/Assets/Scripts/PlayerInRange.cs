using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets._2D;

public class PlayerInRange : MonoBehaviour
{

    public float playerRange;

    public GameObject fireBall;

    public PlatformerCharacter2D player;

    public Transform shotPoint;

    public float waitBewteenShots;
    private float shotCounter;

    // Start is called before the first frame update
    void Start()
    {
        player = FindObjectOfType<PlatformerCharacter2D>();
        shotCounter = waitBewteenShots;
    }

    // Update is called once per frame
    void Update()
    {
        Debug.DrawLine(new Vector3(transform.position.x - playerRange, transform.position.y, transform.position.z), new Vector3(transform.position.x + playerRange, transform.position.y, transform.position.z));
        shotCounter -= Time.deltaTime;

        if (transform.rotation.y > 0 && player.transform.position.x < transform.position.x && player.transform.position.x > transform.position.x - playerRange && shotCounter < 0)
        {
            Instantiate(fireBall, shotPoint.position, shotPoint.rotation);
            shotCounter = waitBewteenShots;
        }

        if (transform.rotation.y < 0 && player.transform.position.x > transform.position.x && player.transform.position.x < transform.position.x + playerRange && shotCounter < 0)
        {
            Instantiate(fireBall, shotPoint.position, shotPoint.rotation);
            shotCounter = waitBewteenShots;
        }
    }
}
