using UnityEngine;
using System.Collections;

public class Targets : MonoBehaviour {

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.transform.tag == "bullet")
        {
            Destroy(gameObject);
            Destroy(other.gameObject);
        }
    }
}
