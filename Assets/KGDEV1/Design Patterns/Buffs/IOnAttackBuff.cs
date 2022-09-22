using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IOnAttackBuff
{
    OnAttackBuffType onAttackBuffType { get; set; }
    void OnAttack();
}

public enum OnAttackBuffType
{
    OnAttackBuffType0 = 0,
    OnAttackBuffType1 = 1,
    OnAttackBuffType2 = 2,
}