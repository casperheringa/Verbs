using UnityEngine;
using System.Collections;

public class Bullet : MonoBehaviour{

    void OnBecameInvisible()
    {
        Destroy(gameObject);
    }
    void Update()
    {
        transform.Translate(Vector3.up * .2f);
    }
    void OnTriggerEnter2D(Collider2D other) {
        if (other.transform.tag == "Floor")
        {
            Destroy(gameObject);
        }
    }
    
}