using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Score : MonoBehaviour
{
    [SerializeField]
    private Image bar;

    float decreaseTimeDelay;

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
        if (type == "Circle")
        {
            m_Score++;
        }
        else if (type == "FakeCircle")
        {
            timer.Penalty();
        }
    }
    // Update is called once per frame
    void Update()
    {
        EndGame();
    }

    void EndGame()
    {
        if (timer.seconds <= 0)
        {
            Data.SaveScore(m_Score);
            SceneManager.LoadScene("LoseScene");
        }
    }
    


}

