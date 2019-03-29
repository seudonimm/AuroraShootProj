using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Explode : MonoBehaviour
{
    [SerializeField] GameObject bullet;
    [SerializeField] GameObject spawn;

    [SerializeField] float projSpeed;

    [SerializeField] float cooldown;
    [SerializeField] float decCooldown;
    [SerializeField] float cooldownTime;

    // Start is called before the first frame update
    void Start()
    {

        //Fire();
    }

    // Update is called once per frame
    void Update()
    {
        cooldownTime = cooldownTime - decCooldown;

        if(cooldownTime <= 0)
        {
            Fire();
            Destroy(gameObject);
        }
    }

    void Fire()
    {
        GameObject laser = Instantiate(bullet, transform.position, Quaternion.identity) as GameObject;

        laser.GetComponent<Rigidbody2D>().velocity = new Vector2(0, projSpeed) * Time.deltaTime;

    }

    private void OnCollisionEnter2D(Collision2D col)
    {
        //if (col.gameObject.CompareTag("Enemy"))
        //{
        //    Fire();
        //    Destroy(gameObject);
        //}
    }
}
