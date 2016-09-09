using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ProgressBarManagement : MonoBehaviour {
	[SerializeField]
	private Image bar;

	float decreaseTimeDelay;

	public TimerManager time;
	public GameEvolution game;

	// Use this for initialization
	void Start () 
	{
		decreaseTimeDelay = 1.5f;
		//StartCoroutine(ConstantDecrementBar());
		//StartCoroutine(GameEvolution.SpeedUp());
	}
	
	// Update is called once per frame
	void Update ()
	{
        ConstantDecrementBar();
        GameEvolution.SpeedUp();
		ChangeBarColor();
		LoseGame();
	}

	void LoseGame()
	{
		if(bar.fillAmount <= 0)
		{
			DataManager.SaveTime(time.minutes, time.seconds);
			SceneManager.LoadScene("LoseScene");
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
	void ConstantDecrementBar()
	{
        //yield return new WaitForSeconds(5.0f);
		//while(true)
		//{
		bar.fillAmount -= GameEvolution.decreaseRate;
		//	//yield return new WaitForSeconds(0.5f);
		//}
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
