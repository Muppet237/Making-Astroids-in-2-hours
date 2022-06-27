using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot:MonoBehaviour {

    public GameObject bulletPrefab;
    
    void Start() {

    }

    void Update() {
        if(!Input.GetKeyDown(KeyCode.Space))
            return;

        GameObject bullet = Instantiate(bulletPrefab, transform.position, Quaternion.identity);
        bullet.transform.rotation = transform.rotation;
    }
}
