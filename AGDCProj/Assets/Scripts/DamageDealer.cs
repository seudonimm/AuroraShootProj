using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageDealer : MonoBehaviour {

    [SerializeField] int damage = 100;
    [SerializeField] int remainingLife = 2;

    [SerializeField] int scoreValue;

    [SerializeField] GameObject score;

    private void Start()
    {
        score = GameObject.Find("Level Manager");
    }

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

                LevelManager l1 = score.GetComponent<LevelManager>();
                l1.score  = l1.score + scoreValue;

                Destroy(gameObject);
            }
        }

    }
}   
