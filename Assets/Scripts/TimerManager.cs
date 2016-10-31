using UnityEngine;

using UnityEngine.UI;

using System.Collections;

public class TimerManager : MonoBehaviour {
	public Text timerText;
	public float seconds;
	void Start () 
	{
		seconds = 60;

	}
	
	// Update is called once per frame
	void Update () 
	{
        //	timerText.text = (int)minutes +":"+ (int)seconds;
        timerText.text =((int)seconds).ToString();
        seconds -= Time.deltaTime;
	}
    public void Penalty()
    {
        seconds -= 10;

    }

}
