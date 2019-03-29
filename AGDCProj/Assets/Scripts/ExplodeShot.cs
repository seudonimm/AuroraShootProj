using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExplodeShot : MonoBehaviour
{
    [SerializeField] GameObject bullet;
    [SerializeField] GameObject spawn;

    [SerializeField] float projSpeed;


    // Start is called before the first frame update
    void Start()
    {
        Fire();
    }

    // Update is called once per frame
    void Update()
    {

    }

    void Fire()
    {
        GameObject laser = Instantiate(bullet, transform.position, Quaternion.identity) as GameObject;

        laser.GetComponent<Rigidbody2D>().velocity = new Vector2(0, projSpeed) * Time.deltaTime;

    }
}
