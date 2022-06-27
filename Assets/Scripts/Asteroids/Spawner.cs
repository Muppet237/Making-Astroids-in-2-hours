using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner:MonoBehaviour {

    public GameObject bigAsteroids, player;
    float xPos, yPos;
    bool spawnChecked;

    void Start() {
        for(int i = 0; i < 4; i++) {
            SpawnChecker();
        }
        spawnChecked = true;
    }

    void Update() {

    }

    void SpawnChecker() {
        while(!spawnChecked) {
            xPos = Random.Range(-43, 43);
            yPos = Random.Range(-24, 24);

            Vector2 spawnPos = new Vector2(xPos, yPos);
            if(Vector2.Distance(player.transform.position, spawnPos) > 15) {
                Instantiate(bigAsteroids, spawnPos, Quaternion.identity);
                spawnChecked = true;
            }
        }
        spawnChecked = false;
    }
}
