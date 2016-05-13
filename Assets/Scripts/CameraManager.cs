using UnityEngine;
using System.Collections;

public class CameraManager : MonoBehaviour {

	// Use this for initialization
	void Start () 
	{
		transform.position = new Vector3(Screen.width/100.0f, Screen.height/100.0f,-10);	
	}
}
