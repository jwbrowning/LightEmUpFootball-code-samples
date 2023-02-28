using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IOffensePersonality {
    
    float QuarterbackScore(Quarterback qb);
    List<string> PreferredPlayTags();
    /*
        qb,wr,rb,ol
    */
    List<int> PreferredPlayerCounts();
    List<int> MaximumYoungPlayerCounts();
    string Type();
    float MaxFieldGoalDistance();

}
