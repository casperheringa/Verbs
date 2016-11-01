using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Timer : MonoBehaviour {
	private float timer;
	[SerializeField]
	private Text timerText;
	private GameObject[] targets;


	void Start () {
	
	}

	void Update () {
		targets = GameObject.FindGameObjectsWithTag("target");
		if (targets.Length > 0) {
			if (Time.time > timer)
			{
				timer = Time.time ;
				timer = Mathf.RoundToInt(timer);
				timerText.text = timer.ToString();
			}
		} else {
			OnComplete();
		}
	}

	void OnComplete(){
		// star code here 
	}
}
