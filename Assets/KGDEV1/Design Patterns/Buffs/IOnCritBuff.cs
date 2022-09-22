using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IOnCritBuff
{
    OnCritBuffType onCritBuffType { get; set; }
    void OnCrit();
}

public enum OnCritBuffType
{
    OnCritBuffType0 = 0,
    OnCritBuffType1 = 1,
    OnCritBuffType2 = 2,
}