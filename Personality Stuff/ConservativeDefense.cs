using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class ConservativeDefense : IDefensePersonality {

    public ConservativeDefense() {

    }

    public List<string> PreferredPlayTags() {
        return new List<string>() {
            "normal",
            "prevent"
        };
    }

    public List<int> PreferredPlayerCounts() {
        return new List<int>() {
            2,4
        };
    }

    public List<int> MaximumYoungPlayerCounts() {
        return new List<int>() {
            3,5,    7
        };
    }

    public string Type() {
        return "Conservative";
    }

}
