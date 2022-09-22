using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IOnGettingKillBuff
{
    OnGettingKillBuffType onGettingKillBuffType { get; set; }
    void OnGettingKill();
}

public enum OnGettingKillBuffType
{
    OnGettingKillBuffType0 = 0,
    OnGettingKillBuffType1 = 1,
    OnGettingKillBuffType2 = 2,
}