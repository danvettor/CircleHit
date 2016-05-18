using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class UITimeManager: MonoBehaviour {
	public Text timeText;
	public string timeType;
	private Vector2 
		bestTime,
		timeValue;

	void Awake ()
	{
		Invoke ("Write"+timeType+"Time",0.0f);
	}
	void WriteBestTime()
	{
		bestTime = DataManager.LoadBestTime();
		timeText.text =(int) bestTime.x + ":" + (int)bestTime.y;
	}
	void WriteCurrentTime()
	{
		timeValue = DataManager.LoadTime();
		timeText.text = (int) timeValue.x + ":" + (int)timeValue.y; 
	}

}
