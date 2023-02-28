using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class AggressiveOffense : IOffensePersonality {

    public AggressiveOffense() {

    }

    public float QuarterbackScore(Quarterback qb) {
        return .8f*qb.ArmStrength + .2f*qb.Accuracy;
    }

    public List<string> PreferredPlayTags() {
        return new List<string>() {
            "deep_pass",
            "short_pass",
        };
    }

    public List<int> PreferredPlayerCounts() {
        return new List<int>() {
            1,3,0,2
        };
    }

    public List<int> MaximumYoungPlayerCounts() {
        return new List<int>() {
            1,3,1,3,    8
        };
    }

    public string Type() {
        return "Aggressive";
    }

    public float MaxFieldGoalDistance() {
        return 30f;
    }

}
