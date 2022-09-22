using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageCommand : IGameObjectCommand
{
    Actor actorToHit;
    int damage;

    public DamageCommand(Actor actorToHit, int damage)
    {
        this.actorToHit = actorToHit;
        this.damage = damage;
    }

    public void Execute()
    {
        actorToHit.TakeDamage(this.damage);
    }
}
