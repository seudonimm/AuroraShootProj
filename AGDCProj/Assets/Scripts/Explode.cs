using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Explode : MonoBehaviour
{
    [SerializeField] GameObject bullet;
    [SerializeField] GameObject spawn;

    [SerializeField] float projSpeed;

    [SerializeField] float timeUntilExplode;

    // Start is called before the first frame update
    void Start()
    {
        Invoke("Fire", timeUntilExplode);
        //Fire();
    }

    // Update is called once per frame
    void Update()
    {

    }


    void Fire()
    {
        GameObject laser = Instantiate(bullet, transform.position, Quaternion.identity) as GameObject;

        laser.GetComponent<Rigidbody2D>().velocity = new Vector2(0, projSpeed) * Time.deltaTime;

        Destroy(gameObject);
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
