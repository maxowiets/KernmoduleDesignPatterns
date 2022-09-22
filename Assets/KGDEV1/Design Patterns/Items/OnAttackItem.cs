using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class OnAttackItem : Item
{
    OnAttackBuffType onAttackBuffType;

    public OnAttackItem(OnAttackBuffType _onAttackBuffType)
    {
        onAttackBuffType = _onAttackBuffType;
    }

    public abstract void PickUpItem(IOnAttackBuff attackBuff);
}
