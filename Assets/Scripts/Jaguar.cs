using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jaguar : MonoBehaviour {
    public void OnTriggerEnter2D(Collider2D other) {
        if (other.CompareTag("Player")) {
            Debug.Log("OnTriggerEnter2D jaguar");
            ChangeScene changeSceneScript = GetComponent<ChangeScene>();
            changeSceneScript.ChangeToScene();
        }
    }
}
