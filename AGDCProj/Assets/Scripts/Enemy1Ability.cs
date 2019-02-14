using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy1Ability : MonoBehaviour
{
    public GameObject proj;
    public Transform projSpawn;

    public bool ability1;
    // Start is called before the first frame update
    void Start()
    {
        ability1 = false;   
    }

    // Update is called once per frame
    void Update()
    {
        
        if (ability1 == true) {
            if (Input.GetMouseButton(0))
            {
                Instantiate(proj, projSpawn.position, projSpawn.rotation);

            }
        }
    }
}
