using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class NeutralDefense : IDefensePersonality {

    public NeutralDefense() {

    }

    public List<string> PreferredPlayTags() {
        return new List<string>() {
            "normal",
        };
    }

    public List<int> PreferredPlayerCounts() {
        return new List<int>() {
            3,3
        };
    }

    public List<int> MaximumYoungPlayerCounts() {
        return new List<int>() {
            4,4,    7
        };
    }

    public string Type() {
        return "Neutral";
    }

}
