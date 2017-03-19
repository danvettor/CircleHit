using UnityEngine;

using UnityEngine.UI;

using System.Collections;

public class TimerManager : MonoBehaviour {
	
    public Image back;
    
	void Update () 
	{
        back.fillAmount += Time.deltaTime/60;
	}
    public IEnumerator Penalty()
    {
        var clamp = Mathf.Clamp(1, 0, 0.1f);
        Debug.Log(clamp);
        var penalty = back.fillAmount + clamp;
        for (int i = 0; i < 5; i++)
        {
            back.fillAmount = Mathf.Lerp(back.fillAmount,penalty,0.05f);
            yield return new WaitForSeconds(0.05f);
        }
    }

}
