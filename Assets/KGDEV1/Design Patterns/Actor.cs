using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Actor : MonoBehaviour
{
    public int health;
    public GameObject attackProjectile;
    public int damage;

    public virtual void TakeDamage(int damage) 
    { 
        health -= damage;
    }

    public virtual void Attack() 
    {
        
    }

    public virtual void OnKill() { }
}
