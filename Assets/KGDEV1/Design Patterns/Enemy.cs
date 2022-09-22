using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : Actor
{
    public override void Attack()
    {
        new AttackCommand(attackProjectile, this, damage);
    }

    public override void OnKill()
    {

    }

    public override void TakeDamage(int damage)
    {
        base.TakeDamage(damage);
    }
}
