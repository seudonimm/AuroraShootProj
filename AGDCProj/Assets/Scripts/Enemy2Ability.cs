using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy2Ability : MonoBehaviour
{
    public GameObject proj;
    public Transform projSpawn;

    public bool ability2;
    // Start is called before the first frame update
    void Start()
    {
        ability2 = false;
    }

    // Update is called once per frame
    void Update()
    {

        if (ability2 == true)
        {
            if (Input.GetMouseButton(0))
            {
                Instantiate(proj, projSpawn.position, projSpawn.rotation);

            }
        }
    }
}
