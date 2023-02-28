using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// utility class to sample from different types of distributions
// used for generating player stats
public static class Distribution {
    
    private static float NextGaussian(float mean,float stdDev) {
        float u1 = Random.value;
        float u2 = Random.value;
        float left = Mathf.Cos((float)2.0 * Mathf.PI * u1);
        float right = Mathf.Sqrt((float)-2.0 * Mathf.Log(u2));
        float z = left * right;
        return mean + (z * stdDev);
    }

    public static float NormalDistribution(float mean,float stdDev,float min,float max) {
        float x;
        do {
            x = NextGaussian(mean,stdDev);
        } while(x>max || x<min);
        return x;
    }

    public static int UniformDistribution(int min,int max) {
        return Random.Range(min,max+1);
    }

}
