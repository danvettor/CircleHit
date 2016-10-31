using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class UITimeManager: MonoBehaviour {
	public Text scoreText;
	public string timeType;

 	void Awake ()
	{
		Invoke ("Write"+timeType+"Score",0.0f);
	}
	void WriteBestScore()
	{
		var bestScore = Data.LoadBestScore();
        scoreText.text = "" + bestScore;
	}
    void WriteCurrentScore()
    {
        var score = Data.LoadCurrentScore();
        scoreText.text = "" + score;
    }
}
