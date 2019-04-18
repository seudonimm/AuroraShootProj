using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Beam : MonoBehaviour
{
    public float speed;

    [SerializeField] GameObject shot;
    [SerializeField] GameObject shooter;

    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Rigidbody2D>().velocity = transform.up * speed;

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D col)
    {
        //Assigns the player var to the Player Object
        GameObject player = GameObject.Find("Player");
        
        //Checks if beam hits Enemy1
        if (col.gameObject.CompareTag("Enemy1"))
        {
            //accesses the Enemy1Ability script and changes the ability1 var to true
            Enemy1Ability e1 = player.GetComponent<Enemy1Ability>();
            e1.ability1 = true;
        }

        //Checks if beam hits Enemy2
        if (col.gameObject.CompareTag("Enemy2"))
        {
            //accesses the Enemy2Ability script and changes the ability2 var to true
            Enemy2Ability e2 = player.GetComponent<Enemy2Ability>();
            e2.ability2 = true;
        }

        //Checks if beam hits Enemy3
        if (col.gameObject.CompareTag("Enemy3"))
        {
            //accesses the Enemy3Ability script and changes the ability3 var to true
            Enemy3Ability e3 = player.GetComponent<Enemy3Ability>();
            e3.ability3 = true;
        }

        //Checks if beam hits Enemy4
        if (col.gameObject.CompareTag("Enemy4"))
        {
            //accesses the Enemy3Ability script and changes the ability3 var to true
            Enemy4Ability e4 = player.GetComponent<Enemy4Ability>();
            e4.ability4 = true;
        }

        Destroy(gameObject);
    }
}
