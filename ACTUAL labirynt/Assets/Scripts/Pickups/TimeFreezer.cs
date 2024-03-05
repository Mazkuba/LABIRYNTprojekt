using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeFreezer : PickUp
{
    [SerializeField]
    int freezeTime = 10;

    public override void Picked()
    {
        GameManager.instance.FreezeTime(freezeTime);
        base.Picked();
    }
}
