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
    
}