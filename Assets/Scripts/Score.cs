using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Advertisements;
public class Score : MonoBehaviour
{
    public Text text;
    private TimerManager timer;

    public int m_Score;

    // Use this for initialization
    void Start()
    {
        m_Score = 0;
        timer = GameObject.FindGameObjectWithTag("Timer").GetComponent<TimerManager>();
    }
    public void ScoreCount(string type)
    {
        print(type);
        if (type == "Circle")
        {
            m_Score++;
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
        text.text = ""+m_Score;
    }

    void EndGame()
    {
        if (timer.back.fillAmount >=1)
        {
            Data.SaveScore(m_Score);
           
            SceneManager.LoadScene("LoseScene");
        }
    }


}

