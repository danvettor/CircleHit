using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour {

	void Start()
	{
		if(SceneManager.GetActiveScene().name == "LogoScene")
			Invoke ("ChangeSceneDelayed",5.0f);
	}
	public void ChangeScene(string sceneName)
	{
        SceneManager.LoadScene(sceneName);

	}

	public void ChangeSceneDelayed()
	{
		SceneManager.LoadScene("IntroScene");
		
	}

}
