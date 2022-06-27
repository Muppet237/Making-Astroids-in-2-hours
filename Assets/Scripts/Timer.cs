using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer:MonoBehaviour {

    int hours = 1, minutes = 1, seconds;
    bool timerActive = true;

    IEnumerator Start() {
        while(timerActive) {
            //Timer runout
            if(hours == -1) {
                timerActive = false;
                break;
            }

            yield return new WaitForSeconds(1f);
            Debug.Log(string.Format("{0:00}:{1:00}:{2:00}", hours, minutes, seconds));
            seconds--;
            if(seconds == -1) {
                seconds = 59;
                minutes--;
            }

            if(minutes == -1) {
                minutes = 59;
                hours--;
            }

        }
    }
}
