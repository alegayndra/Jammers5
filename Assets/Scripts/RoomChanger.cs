using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoomChanger : MonoBehaviour {
    public GameObject virtualCamera;

    public void OnTriggerEnter2D(Collider2D other) {
        Debug.Log("AAAAAAAAAAA");
        if (other.CompareTag("Player") && !other.isTrigger) {
            Debug.Log("QUE PEX");
            virtualCamera.SetActive(true);
        }
    }

    public void OnTriggerExit2D(Collider2D other) {
        if (other.CompareTag("Player") && !other.isTrigger) {
            virtualCamera.SetActive(false);
        }
    }
}
