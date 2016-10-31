using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class UITimeManager: MonoBehaviour {
	public Text scoreText;
	public string timeType;

 	void Awake ()
	{
		Invoke ("Write"+timeType+"Time",0.0f);
	}
	void WriteBestScore()
	{
		var bestScore = Data.LoadBestScore();
        scoreText.text = "Best Score: " + bestScore;
	}
    void WriteScore()
    {
        var score = Data.LoadCurrentScore();
        scoreText.text = "Your Score: " + score;
    }
}
