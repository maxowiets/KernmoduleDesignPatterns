using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Buffs : Actor, IOnAttackBuff, IOnCritBuff, IOnGettingHitBuff, IOnGettingKillBuff
{
    public OnAttackBuffType onAttackBuffType { get; set; }
    public OnCritBuffType onCritBuffType { get; set; }
    public OnGettingHitBuffType onGettingHitBuffType { get; set; }
    public OnGettingKillBuffType onGettingKillBuffType { get; set; }

    public void OnAttack()
    {
        if (onAttackBuffType == OnAttackBuffType.OnAttackBuffType0)
        {
            //effect 1
        }
        if (onAttackBuffType == OnAttackBuffType.OnAttackBuffType1)
        {
            //effect 2
        }
        if (onAttackBuffType == OnAttackBuffType.OnAttackBuffType2)
        {
            //effect 3
        }
    }

    public void OnCrit()
    {
        if (onCritBuffType == OnCritBuffType.OnCritBuffType0)
        {
            //effect 1
        }
        if (onCritBuffType == OnCritBuffType.OnCritBuffType1)
        {
            //effect 2
        }
        if (onCritBuffType == OnCritBuffType.OnCritBuffType2)
        {
            //effect 3
        }
    }

    public void OnGettingHit()
    {
        if (onGettingHitBuffType == OnGettingHitBuffType.OnGettingHitBuffType0)
        {
            //effect 1
        }
        if (onGettingHitBuffType == OnGettingHitBuffType.OnGettingHitBuffType1)
        {
            //effect 2
        }
        if (onGettingHitBuffType == OnGettingHitBuffType.OnGettingHitBuffType2)
        {
            //effect 3
        }
    }

    public void OnGettingKill()
    {
        if (onGettingKillBuffType == OnGettingKillBuffType.OnGettingKillBuffType0)
        {
            //effect 1
        }
        if (onGettingKillBuffType == OnGettingKillBuffType.OnGettingKillBuffType1)
        {
            //effect 2
        }
        if (onGettingKillBuffType == OnGettingKillBuffType.OnGettingKillBuffType2)
        {
            //effect 3
        }
    }
}
