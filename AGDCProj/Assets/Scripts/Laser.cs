using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Laser : MonoBehaviour
{

    public Transform target;
    [SerializeField] float speed = 5f;
    public GameObject laser; 

    void Start()
    {    
        // Locate target
        target = GameObject.FindGameObjectWithTag("Player").transform;
        Vector3 playerPos = new Vector3(target.position.x, target.position.y -5, target.position.z);

        // Aim bullet in player's direction.
        transform.rotation = Quaternion.LookRotation(playerPos);
        laser.GetComponent<Rigidbody2D>().velocity = new Vector2(playerPos.x, playerPos.y);
    }

    // Update is called once per frame
    void Update()
    {
        // Keeps the projectile moving in the player's direction
        transform.position += transform.forward * speed * Time.deltaTime;
    }
}