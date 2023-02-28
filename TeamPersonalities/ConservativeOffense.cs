using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class ConservativeOffense : IOffensePersonality {

    public ConservativeOffense() {

    }

    public float QuarterbackScore(Quarterback qb) {
        return .2f*qb.ArmStrength + .8f*qb.Accuracy;
    }

    public List<string> PreferredPlayTags() {
        return new List<string>() {
            //"short_pass",
            "run",
        };
    }

    public List<int> PreferredPlayerCounts() {
        return new List<int>() {
            1,1,1,3
        };
    }

    public List<int> MaximumYoungPlayerCounts() {
        return new List<int>() {
            1,2,2,4,    8
        };
    }

    public string Type() {
        return "Conservative";
    }

    public float MaxFieldGoalDistance() {
        return 50f;
    }

}
