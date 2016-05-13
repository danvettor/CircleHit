using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ProgressBarManagement : MonoBehaviour {
	[SerializeField]
	private Image bar;
	public float decreaseRate, decreaseTimeDelay;

	public TimerManager time;



	// Use this for initialization
	void Start () 
	{
		StartCoroutine(DecrementBar());
		StartCoroutine(SpeedUp());
	}
	
	// Update is called once per frame
	void Update ()
	{
		
		if(bar.fillAmount > 0.5f)
			bar.color = Color.green;
		else if(bar.fillAmount <= 0.5f &&  bar.fillAmount > 0.2f)
			bar.color = Color.yellow;
		else if (bar.fillAmount <= 0.2f)
			bar.color = Color.red;


		if(bar.fillAmount <= 0)
		{
			print ("Tmepo a ser salvo: "+ time.seconds);
			GameManager.SaveTime(time.minutes, time.seconds);
			Application.LoadLevel("LoseScene");
		}
	}
	IEnumerator DecrementBar()
	{
		while(true)
		{
			bar.fillAmount -= decreaseRate;
			yield return new WaitForSeconds(decreaseTimeDelay);
		}
	}

	IEnumerator SpeedUp()
	{
		while(true)
		{
			decreaseRate += 0.0005f;
			yield return new WaitForSeconds(2.0f);
		}
	}


}
