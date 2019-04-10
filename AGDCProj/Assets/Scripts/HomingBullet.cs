using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class HomingBullet : MonoBehaviour {

    public Transform target;


    [SerializeField] float speed = 5f;
    [SerializeField] float rotateSpeed = 200f;

    [SerializeField] float decCooldown;
    [SerializeField] float cooldownTime;

    private Rigidbody2D rb;

	// Use this for initialization
	void Start () {
        //Locates the Player

        target = GameObject.FindGameObjectWithTag("Player").transform;
        rb = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void FixedUpdate () {

        //The direction from the missle to the target.
        Vector2 direction = (Vector2)target.position - rb.position;

        direction.Normalize();

        float rotateAmount = Vector3.Cross(direction, -transform.up).z;

        rb.angularVelocity = -rotateAmount * rotateSpeed;

        rb.velocity = -transform.up * speed;

        cooldownTime = cooldownTime - decCooldown;

        if (cooldownTime <= 0)
        {
            Destroy(gameObject);
        }
    }
}
