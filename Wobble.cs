using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// script component to make an object look like it wobbles (for game feel)
public class Wobble : MonoBehaviour {

    Vector2 target;
    Vector2 speeds;
    Vector2 start;
    float dif;

    public void StartWobble() {
        StopCoroutine("WobbleCoroutine");
        start = new Vector2(1,1);
        target = new Vector2(1.1f*start.x,.9f*start.y);
        dif = target.x - start.x;
        speeds = new Vector2(Random.value + 14f,Random.value + 14f);
        StartCoroutine("WobbleCoroutine");
    }

    IEnumerator WobbleCoroutine() {
        
        float duration = 1f;
        float time = duration;
        while(time > 0 || Mathf.Abs(transform.localScale.x-target.x)>.1f || Mathf.Abs(transform.localScale.y-target.y)>.1f) {
            time-=Time.deltaTime;

            float speedMultiplier = 1f-time/duration;
            speedMultiplier*=speedMultiplier;
            speedMultiplier = 1f-speedMultiplier;

            float targetDif = time/duration * dif;

            float x,y;
            if(transform.localScale.x > start.x+targetDif) {
                target.x = start.x-targetDif;
            } else if(transform.localScale.x < start.x-targetDif) {
                target.x = start.x+targetDif;
            }
            x = Mathf.Lerp(transform.localScale.x,target.x,speedMultiplier*speeds.x*Time.deltaTime);

            if(transform.localScale.y > start.y+targetDif) {
                target.y = start.y-targetDif;
            } else if(transform.localScale.y < start.y-targetDif) {
                target.y = start.y+targetDif;
            }
            y = Mathf.Lerp(transform.localScale.y,target.y,speedMultiplier*speeds.y*Time.deltaTime);
            
            transform.localScale = new Vector3(x,y,1);
            // transform.localScale = new Vector3(start.x, start.y, 1);

            yield return null;
        }

    }

}
