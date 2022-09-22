using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExtraDamageOnAttackItem : OnAttackItem
{
    OnAttackBuffType onAttackBuffType = OnAttackBuffType.OnAttackBuffType0;
    public ExtraDamageOnAttackItem(OnAttackBuffType _onAttackBuffType) : base(_onAttackBuffType)
    {
        
    }

    public override void PickUpItem(IOnAttackBuff attackBuff)
    {
        if (attackBuff.onAttackBuffType != onAttackBuffType)
        {
            attackBuff.onAttackBuffType |= onAttackBuffType;
        }
        //and maybe add some extra damage --> does need extra variables in buff scripts
    }
}
