using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IOnGettingHitBuff
{
    OnGettingHitBuffType onGettingHitBuffType { get; set; }
    void OnGettingHit();
}

public enum OnGettingHitBuffType
{
    OnGettingHitBuffType0 = 0,
    OnGettingHitBuffType1 = 1,
    OnGettingHitBuffType2 = 2,
}