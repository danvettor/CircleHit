using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ProgressBarManagement : MonoBehaviour {
	[SerializeField]
	private Image bar;

	float decreaseTimeDelay;

	public TimerManager time;
	public GameEvolution game;

	// Use this for initialization
	void Start () 
	{
		decreaseTimeDelay = 0.005f;
		StartCoroutine(ConstantDecrementBar());
		StartCoroutine(GameEvolution.SpeedUp());
	}
	
	// Update is called once per frame
	void Update ()
	{

		ChangeBarColor();
		LoseGame();
	}

	void LoseGame()
	{
		if(bar.fillAmount <= 0)
		{
			DataManager.SaveTime(time.minutes, time.seconds);
			Application.LoadLevel("LoseScene");
		}
	}

	void ChangeBarColor()
	{
		if(bar.fillAmount > 0.5f)
			bar.color = Color.green;
		else if(bar.fillAmount <= 0.5f &&  bar.fillAmount > 0.2f)
			bar.color = Color.yellow;
		else if (bar.fillAmount <= 0.2f)
			bar.color = Color.red;

	}
	IEnumerator ConstantDecrementBar()
	{
		while(true)
		{
			bar.fillAmount -= GameEvolution.decreaseRate;
			yield return new WaitForSeconds(decreaseTimeDelay);
		}
	}
	public void DecrementBar(float value)
	{
		bar.fillAmount -= value;
	}
	public void IncreaseBar(float value)
	{
		bar.fillAmount += value;
	}
    public void DecreaseBar(float value)
    {
        bar.fillAmount -= value;
    }

}
