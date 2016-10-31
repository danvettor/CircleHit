	using UnityEngine;
using System.Collections;

public static class Data {

	public static void SaveScore(int score)
	{
		int bestScore = LoadBestScore();
		if(score > bestScore)
		{
			PlayerPrefs.SetInt("BestScore", score);
		}
	}	
	public static int LoadBestScore()
	{
        return PlayerPrefs.HasKey("BestScore") ? PlayerPrefs.GetInt("BestScore") : 0;
	}
    public static int LoadCurrentScore()
    { return 0; }
}
