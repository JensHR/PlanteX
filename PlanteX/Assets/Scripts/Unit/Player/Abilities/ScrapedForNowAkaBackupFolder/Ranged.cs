using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ranged : AbilityBehaviors
{
    private const string name = "Ranged";
    private const BehaviorStartTime startTime = BehaviorStartTime.Beginning;

    public Ranged() : base(name, startTime)
    {

    }
}
