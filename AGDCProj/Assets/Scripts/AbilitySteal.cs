using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AbilitySteal : MonoBehaviour
{
    public GameObject beam;
    public Transform beamSpawn;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(1))
        {
            Instantiate(beam, beamSpawn.position, beamSpawn.rotation);
        }
    }
}
