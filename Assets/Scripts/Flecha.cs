using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flecha : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnTriggerEnter2D(Collider2D other) {
        if (other.CompareTag("Player")) {
            other.gameObject.SendMessage("ApplyDamage", 2f);
        }
        Destroy(gameObject);
    }
}
