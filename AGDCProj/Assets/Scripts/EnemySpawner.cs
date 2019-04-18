using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject enemy;
    public GameObject path;




    // Start is called before the first frame update
    void Start()
    {
        Instantiate(enemy, enemy.transform.position, enemy.transform.rotation);

        Instantiate(path, path.transform.position, path.transform.rotation);

    }

    // Update is called once per frame
    void Update()
    {

    }
}
