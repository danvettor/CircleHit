using UnityEngine;
using System.Collections;

public class GameEvolution : MonoBehaviour {

	public int gameLevel;

	void Awake () 
	{
		gameLevel = 1;
	}
	
	void Update () 
	{
	
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
