using UnityEngine;
using System.Collections;

public class SceneChanger : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    public void LoadLevel(string level)
    {
        Application.LoadLevel("Jelmer");
    }
}
