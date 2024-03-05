using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointAdder : PickUp
{
    [SerializeField]
    int points = 5;

    public override void Picked()
    {
        GameManager.instance.AddPoints(points);
        base.Picked();
    }
}
