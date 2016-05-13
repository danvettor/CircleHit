using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class BestTimeManager : MonoBehaviour {
	public Text bestTimeText;
	private Vector2 bestTime;
	void Start ()
	{
		bestTime = GameManager.LoadTime();
		print ("melhor tempo :" + bestTime.y);
		bestTimeText.text =(int) bestTime.x+":"+(int)bestTime.y;	
	}
	
}
