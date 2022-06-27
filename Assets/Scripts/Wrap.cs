using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wrap:MonoBehaviour {
    void Update() {
        if(transform.position.x <= -44) {
            transform.position = new Vector2(43, transform.position.y);
        }

        if(transform.position.x >= 44) {
            transform.position = new Vector2(-43, transform.position.y);
        }

        if(transform.position.y <= -25) {
            transform.position = new Vector2(transform.position.x, 24);
        }

        if(transform.position.y >= 25) {
            transform.position = new Vector2(transform.position.x, -24);
        }
    }
}
