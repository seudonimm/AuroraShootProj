using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriShot : MonoBehaviour
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
        Vector2 right = new Vector2(transform.position.x+1, transform.position.y);
        Vector2 left = new Vector2(transform.position.x-1, transform.position.y);

        GameObject laser1 = Instantiate(bullet, transform.position, Quaternion.identity) as GameObject;
        GameObject laser2 = Instantiate(bullet, right, Quaternion.identity) as GameObject;
        GameObject laser3 = Instantiate(bullet, left, Quaternion.identity) as GameObject;

        laser1.GetComponent<Rigidbody2D>().velocity = new Vector2(0, projSpeed) * Time.deltaTime;
        laser2.GetComponent<Rigidbody2D>().velocity = new Vector2(0, projSpeed) * Time.deltaTime;
        laser3.GetComponent<Rigidbody2D>().velocity = new Vector2(0, projSpeed) * Time.deltaTime;

    }
}
