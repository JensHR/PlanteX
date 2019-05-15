using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AbilityBehaviors
{

    private string name;
    private BehaviorStartTime startTime;

    public enum BehaviorStartTime
    {
        Beginning,
        Middle,
        End
    }

    public AbilityBehaviors(string aName, BehaviorStartTime aStartTime)
    {
        name = aName;
        startTime = aStartTime;
    }

    public void initiate()
    {

    }


}
