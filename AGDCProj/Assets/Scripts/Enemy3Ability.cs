using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy3Ability : MonoBehaviour
{
    public GameObject proj;
    public Transform projSpawn;

    public bool ability3;

    [SerializeField] GameObject laserPrefab;
    [SerializeField] float projectileSpeed = 10f;
    [SerializeField] float projectileFiringPeriod = 0.1f;

    Coroutine firingCoroutine;

    // Start is called before the first frame update
    void Start()
    {
        ability3 = false;
    }

    // Update is called once per frame
    void Update()
    {
        Fire();
        //if (ability1 == true) {
        //    if (Input.GetMouseButton(0))
        //    {
        //        Instantiate(proj, projSpawn.position, projSpawn.rotation);

        //    }
        //}
    }

    private void Fire()
    {
        if (ability3 == true)
        {
            if (Input.GetMouseButtonDown(0))
            {
                firingCoroutine = StartCoroutine(FireContinuously());
            }
            if (Input.GetMouseButtonUp(0))
            {
                StopCoroutine(firingCoroutine);
            }
        }
    }

    IEnumerator FireContinuously()
    {


        while (true)
        {
            GameObject laser = Instantiate(laserPrefab, transform.position, Quaternion.identity) as GameObject;
            laser.GetComponent<Rigidbody2D>().velocity = new Vector2(0, projectileSpeed);
            yield return new WaitForSeconds(projectileFiringPeriod);
        }

    }
}
