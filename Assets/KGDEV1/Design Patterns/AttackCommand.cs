using System;
using System.Collections;
using System.Collections.Generic;
using System.Windows.Input;
using UnityEngine;

public class AttackCommand : IGameObjectCommand
{
    GameObject projectile;
    Vector3 position;
    Quaternion rotation;
    int damage;

    public AttackCommand(GameObject projectile, Actor actor, int damage)
    {
        this.projectile = projectile;
        this.position = actor.transform.position;
        this.rotation = actor.transform.rotation;
        this.damage = damage;
    }

    public void Execute()
    {
        GameObject newProjectile = GameObject.Instantiate(projectile, position, rotation);
        newProjectile.GetComponent<Projectile>().damage = this.damage;
    }
}
