using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IDefensePersonality {
    
    List<string> PreferredPlayTags();
    /*
        dl,db
    */
    List<int> PreferredPlayerCounts();
    List<int> MaximumYoungPlayerCounts();
    string Type();

}
