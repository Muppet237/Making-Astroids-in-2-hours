using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score:MonoBehaviour {

    public int scoreTotal;
    Text scoreText;
    
    void Start() {
        scoreText = GetComponent<Text>();
    }

    public void AddScore(int amount) {
        scoreTotal += amount;
        scoreText.text = scoreTotal.ToString();
    }
}
