using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class OnGettingHitItem : Item
{
    OnGettingHitBuffType onGettingHitBuffType;

    public OnGettingHitItem(OnGettingHitBuffType _onGettingHitBuffType)
    {
        onGettingHitBuffType = _onGettingHitBuffType;
    }

    public abstract void PickUpItem(IOnGettingHitBuff onGettingHitBuff);
}
