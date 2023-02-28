using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class NeutralOffense : IOffensePersonality {

    public NeutralOffense() {

    }

    public float QuarterbackScore(Quarterback qb) {
        return .5f*qb.ArmStrength + .5f*qb.Accuracy;
    }

    public List<string> PreferredPlayTags() {
        return new List<string>() {
            "deep_pass",
            "short_pass",
            "run",
        };
    }

    public List<int> PreferredPlayerCounts() {
        return new List<int>() {
            1,2,1,2
        };
    }

    public List<int> MaximumYoungPlayerCounts() {
        return new List<int>() {
            1,3,2,3,    8
        };
    }

    public string Type() {
        return "Neutral";
    }

    public float MaxFieldGoalDistance() {
        return 40f;
    }

}
