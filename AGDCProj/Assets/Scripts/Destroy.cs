using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy : MonoBehaviour
{
    [SerializeField] int timeToDie;

    // Start is called before the first frame update
    void Start()
    {
        Invoke("Die", timeToDie);
    }

    void Die()
    {
        Destroy(gameObject);
    }
}
