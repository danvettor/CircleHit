using UnityEngine;
using System.Collections;
using UnityEngine.UI;


public class GeometricForm : MonoBehaviour
{

    private GeometricSpawner spawner;
    private Score score;

    void Awake()
    {
        //trocar isso posteriormente
        spawner = GameObject.FindGameObjectWithTag("Spawner").GetComponent<GeometricSpawner>();
        score = GameObject.FindGameObjectWithTag("Score").GetComponent<Score>();
    }
    public void GeometricResponse()
    {
        spawner.SpawnGeometric();
        score.ScoreCount(transform.tag);

    }

}

