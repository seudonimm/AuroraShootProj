using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageDealer : MonoBehaviour {

    [SerializeField] int damage = 100;
    [SerializeField] int remainingLife = 2;
    
    public int GetDamage()
    {
        return damage;
    }
    public void Hit()
    {
        Destroy(gameObject);
    }
    public void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.CompareTag("Projectile Player"))
        {
            remainingLife--;


            if (remainingLife <= 0)
            {
                Debug.Log("DIEEEEEEEEEEEEEEEEEEEEEEEEEEEEEE");
                Destroy(gameObject);
            }
        }

    }
}   
