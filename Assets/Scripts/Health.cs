using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health:MonoBehaviour {

    public GameObject[] lifes;

    int health = 3;

    void TakeLife() {
        health--;

        if(health <= 0) {
            Time.timeScale = 0;
        }

        for(int i = 0; i < 3; i++) {
            if(i < health) {
                lifes[i].SetActive(true);
            } else {
                lifes[i].SetActive(false);
            }
        }
    }

    void OnTriggerEnter2D(Collider2D collision) {
        if(collision.CompareTag("Asteroid"))
            TakeLife();
    }
}
