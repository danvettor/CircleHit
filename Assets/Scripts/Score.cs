using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Advertisements;
public class Score : MonoBehaviour
{
    public Text text;
    private TimerManager timer;

    public int score;

    // Use this for initialization
    void Start()
    {
		score = 0;
        timer = GameObject.FindGameObjectWithTag("Timer").GetComponent<TimerManager>();
    }
    public void ScoreCount(string type)
    {
        if (type == "Circle")
        {
			score++;
        }
        else if (type == "FakeCircle")
        {
            StartCoroutine(timer.Penalty());
        }
    }
    // Update is called once per frame
    void Update()
    {
        EndGame();
		text.text = ""+ score;
    }

    void EndGame()
    {

        if (timer.back.fillAmount >=1)
        {
            Data.SaveScore(score);  
            SceneManager.LoadScene("LoseScene");
			AdsManager.ShowAdvertisement();
        }
    }


}

