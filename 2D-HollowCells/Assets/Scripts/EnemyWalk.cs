using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyWalk : MonoBehaviour
{

    public float speed;
    public float distance = 2f;

    private bool movvingRight = true;

    public Transform groundDetection;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.right * speed * Time.deltaTime);
        // returns info about an object detected by raycast
        // Casts a ray against colliders in the gamescene
        RaycastHit2D groundInfo = Physics2D.Raycast(groundDetection.position, Vector2.down, distance); // creates a ray/laser downwards with the distance of 2 from the gameObject groundDetection
        if(groundInfo.collider == false)
            if(movvingRight == true)
            {
                transform.eulerAngles = new Vector3(0, -180, 0);
                movvingRight = false;
            }
        else
        {
                transform.eulerAngles = new Vector3(0, 0, 0);
                movvingRight = true;
            }
    }
}
