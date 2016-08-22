	using UnityEngine;
using System.Collections;

public static class DataManager {

	public static void SaveTime(float minutes, float seconds)
	{
		Vector2 bestTime = LoadBestTime();
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
		PlayerPrefs.SetFloat("CurrentSeconds", seconds);
		PlayerPrefs.SetFloat("CurrentMinutes", minutes);

	}
	
	public static Vector2 LoadTime()
	{
		if (PlayerPrefs.HasKey("CurrentSeconds") &&
		    PlayerPrefs.HasKey("CurrentMinutes"))
		{
			return new Vector2(PlayerPrefs.GetFloat("CurrentMinutes"),PlayerPrefs.GetFloat("CurrentSeconds"));
		}
		else
			return Vector2.zero;
	
	}
	public static Vector2 LoadBestTime()
	{
		if (PlayerPrefs.HasKey("BestSeconds"))
		{
			return new Vector2(PlayerPrefs.GetFloat("BestMinutes"),PlayerPrefs.GetFloat("BestSeconds"));
		}
		else
			return Vector2.zero;
	}
}
