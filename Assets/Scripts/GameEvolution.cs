using UnityEngine;
using System.Collections;

public class GameEvolution : MonoBehaviour {

	public int gameLevel;
	public float decreaseRate;
    

	IEnumerator IncreaseLevel()
	{
		while(true)
		{
			yield return new WaitForSeconds(10.0f/gameLevel);
			gameLevel++;
		}
	}

}
