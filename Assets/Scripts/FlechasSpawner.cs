using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlechasSpawner : MonoBehaviour {

    public GameObject flechaPrefab;
    private int ticks;
    // Start is called before the first frame update
    void Start() {
        ticks = 0;
    }

    // Update is called once per frame
    void Update() {
        if (ticks <= 0 && Random.Range(-10.0f, 20.0f) > 0) {
            ticks = 60;
            Instantiate(flechaPrefab, new Vector3(transform.position.x + Random.Range(-5.0f, 5.0f), transform.position.y+ Random.Range(-2.0f, 2.0f), 0), Quaternion.identity);
        } else {
            ticks--;
        }
    }
}
