using UnityEngine;

using UnityEngine.UI;

using System.Collections;

public class TimerManager : MonoBehaviour {
	public Text timerText;
	public float minutes, seconds;
	void Start () 
	{
		seconds = 0;
		minutes = 0;
	}
	
	// Update is called once per frame
	void Update () 
	{
		timerText.text = (int)minutes +":"+ (int)seconds;
		seconds += Time.deltaTime;
		if(seconds > 60.0f)
		{
			seconds = 0.0f;
			minutes++;
		}
	}
}
