using UnityEngine;
using System.Collections;

public class GameEvolution : MonoBehaviour {

	public static int gameLevel;
	public static float decreaseRate;

	void Awake () 
	{
		gameLevel = 1;
		decreaseRate = 0.0001f;
	}

	IEnumerator IncreaseLevel()
	{
		while(true)
		{
			yield return new WaitForSeconds(10.0f/gameLevel);
			gameLevel++;
		}
	}

}
