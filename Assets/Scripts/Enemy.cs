using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public int health = 20;
    public bool isDead = false;

    public GameObject gun;
    int damage = gun.GetComponent<Shooting>().damage;

    public void TakingDamage(int damage)
    {
        health = health - damage;

        if (health <= 0 && isDead == false)
        {
            Debug.Log("Dead");
            isDead = true;
            
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "bullet")
        {
            Debug.Log("HIT");
            TakingDamage(damage);
        }
    }
}
