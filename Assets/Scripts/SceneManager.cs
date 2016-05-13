using UnityEngine;
using System.Collections;

public class SceneManager : MonoBehaviour {

	void Start()
	{
		if(Application.loadedLevelName == "LogoScene")
			Invoke ("ChangeSceneDelayed",6.0f);
	}
	public void ChangeScene(string sceneName)
	{
		Application.LoadLevel(sceneName);

	}

	public void ChangeSceneDelayed()
	{
		Application.LoadLevel("IntroScene");
		
	}

}
