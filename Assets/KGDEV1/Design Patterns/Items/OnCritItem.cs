using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class OnCritItem : Item
{
    OnCritBuffType onCritBuffType;

    public OnCritItem(OnCritBuffType _onCritBuffType)
    {
        onCritBuffType = _onCritBuffType;
    }

    //Decorator
    public abstract void PickUpItem(IOnCritBuff onCritBuff);
}
