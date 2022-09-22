using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : Actor, IControllable
{
    public InputHandler inputHandler = new InputHandler();

    // Start is called before the first frame update
    void Start()
    {
        inputHandler.BindInputToCommand(KeyCode.Mouse0, new AttackCommand(attackProjectile, this, damage));
    }

    // Update is called once per frame
    void Update()
    {
        inputHandler.HandleInput();
    }

    public override void OnKill()
    {

    }

    public override void TakeDamage(int damage)
    {
        base.TakeDamage(damage);
    }
}
