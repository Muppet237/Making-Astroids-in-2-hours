using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet:MonoBehaviour {

    float bulletSpeed = 20, lifeTimer = 2.5f;
    Rigidbody2D rgbd2D;

    IEnumerator Start() {
        rgbd2D = GetComponent<Rigidbody2D>();
        rgbd2D.velocity = transform.up * bulletSpeed;
        yield return new WaitForSeconds(lifeTimer);

        Destroy(gameObject);
    }

    void OnTriggerEnter2D(Collider2D collision) {
        if(collision.CompareTag("Player"))
            return;

        Destroy(gameObject);
    }
}
