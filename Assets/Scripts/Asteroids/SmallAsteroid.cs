using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SmallAsteroid:MonoBehaviour {
    Score scoreScript;

    SpriteRenderer spriteRenderer;
    public Sprite[] asteroids;

    Rigidbody2D rgbd2D;
    float speed = 15;
    int worth = 100;

    void Start() {
        scoreScript = GameObject.Find("Score").GetComponent<Score>();
        spriteRenderer = GetComponent<SpriteRenderer>();
        rgbd2D = GetComponent<Rigidbody2D>();

        spriteRenderer.sprite = asteroids[Random.Range(0, 3)];
        transform.rotation = Quaternion.Euler(0, 0, Random.Range(0, 360));
        rgbd2D.velocity = transform.up * speed;
    }

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

    void OnTriggerEnter2D(Collider2D collision) {
        if(!collision.CompareTag("Bullet"))
            return;

        scoreScript.AddScore(worth);
        Destroy(gameObject);
    }
}
