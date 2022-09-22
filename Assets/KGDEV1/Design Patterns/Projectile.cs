using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    public int damage;
    
    private void MoveProjectile()
    {

    }

    public void OnHit(Actor actor)
    {
        new DamageCommand(actor, damage);
    }
}
