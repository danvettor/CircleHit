using UnityEngine;
using System.Collections;

public class CameraManager : MonoBehaviour {

	// Use this for initialization
	void Start () 
	{
		transform.position = new Vector3(Screen.width/200.0f, Screen.height/200.0f,-10);	
	}

}
