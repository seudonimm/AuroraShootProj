using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour
{
    [SerializeField] GameObject spawner;
    int counter = 1;
    [SerializeField] float time;
    GameObject[] spawnGroups = new GameObject[8];
    [SerializeField] GameObject spawnGroup1;
    [SerializeField] GameObject spawnGroup2;
    [SerializeField] GameObject spawnGroup3;
    [SerializeField] GameObject spawnGroup4;
    [SerializeField] GameObject spawnGroup5;
    [SerializeField] GameObject spawnGroup6;
    [SerializeField] GameObject spawnGroup7;
    [SerializeField] GameObject spawnGroup8;


    // Start is called before the first frame update
    void Start()
    {
        

        InvokeRepeating("Spawn", time, time);
    }

    // Update is called once per frame
    void Update()
    {
        //i could probably use a loop for this...
        if(counter == 1)
        {
            spawner = spawnGroup1;
            
        }
        else if(counter == 2)
        {
            spawner = spawnGroup2;

        }
        else if (counter == 3)
        {
            spawner = spawnGroup3;

        }
        else if (counter == 4)
        {
            spawner = spawnGroup4;

        }
        else if (counter == 5)
        {
            spawner = spawnGroup5;

        }
        else if (counter == 6)
        {
            spawner = spawnGroup6;

        }
        else if (counter == 7)
        {
            spawner = spawnGroup7;

        }
        else if (counter == 8)
        {
            spawner = spawnGroup8;

        }
        
    }

    void Spawn()
    {
        Instantiate(spawner, spawner.transform.position, spawner.transform.rotation);
        counter++;


    }
}
