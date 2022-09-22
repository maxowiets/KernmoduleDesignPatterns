using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class OnGettingKillItem : Item
{
    OnGettingKillBuffType onGettingKillBuffType;

    public OnGettingKillItem(OnGettingKillBuffType _onGettingKillBuffType)
    {
        onGettingKillBuffType = _onGettingKillBuffType;
    }

    public abstract void PickUpItem(IOnGettingKillBuff onGettingKillBuff);
}
