using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class AggressiveDefense : IDefensePersonality {

    public AggressiveDefense() {

    }

    public List<string> PreferredPlayTags() {
        return new List<string>() {
            "blitz",
            "normal",
        };
    }

    public List<int> PreferredPlayerCounts() {
        return new List<int>() {
            4,2
        };
    }

    public List<int> MaximumYoungPlayerCounts() {
        return new List<int>() {
            5,3,    7
        };
    }

    public string Type() {
        return "Aggressive";
    }

}
