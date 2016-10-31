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

    public static int score;

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
            //DataManager.SaveTime(time.minutes, time.seconds);
            SceneManager.LoadScene("LoseScene");
        }
    }
    


}

