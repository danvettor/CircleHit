using UnityEngine;
using System.Collections;

public static class GameManager {

	public static void SaveTime(float minutes, float seconds)
	{
		Vector2 bestTime = LoadTime();
		if(minutes > bestTime.x)
		{
			PlayerPrefs.SetFloat("BestSeconds", seconds);
			PlayerPrefs.SetFloat("BestMinutes", minutes);
		}
		else
		{
			if(seconds > bestTime.y)
			{
				PlayerPrefs.SetFloat("BestSeconds", seconds);

			}
		}
	}
	public static Vector2 LoadTime()
	{
		if (PlayerPrefs.HasKey("BestSeconds"))
		{
			return new Vector2(PlayerPrefs.GetFloat("BestMinutes"),PlayerPrefs.GetFloat("BestSeconds"));
		}
		else
			return Vector2.zero;
	}
}
