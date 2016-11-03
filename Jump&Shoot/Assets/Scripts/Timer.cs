using UnityEngine;

using UnityEngine.UI;

public class Timer : MonoBehaviour {
	private float _timer;
	[SerializeField]
	private Text _timerText;
	private GameObject[] _targets;


	void Start () {
	
	}

	void Update () {
		_targets = GameObject.FindGameObjectsWithTag("target");
		if (_targets.Length > 0) {
		    if (!(Time.time > _timer)) return;
		    _timer = Time.time;
		    _timer = Mathf.RoundToInt(_timer);
		    // ReSharper disable once SpecifyACultureInStringConversionExplicitly
		    _timerText.text = _timer.ToString();
		} else {
			OnComplete();
		}
	}

	void OnComplete(){
		// star code here 
	}
}
