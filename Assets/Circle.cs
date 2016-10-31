using UnityEngine;
using System.Collections;

public class Circle : GeometricForm
{
    private GeometricSpawner spawner;
    private Score score;
    void Awake()
    {
        //trocar isso posteriormente
       spawner = GameObject.FindGameObjectWithTag("Spawner").GetComponent<GeometricSpawner>();
        score = GameObject.FindGameObjectWithTag("Score").GetComponent<Score>();
    }
    public override void DestroyGeometric(GameObject circle)
    {
        base.DestroyGeometric(circle);
        spawner.SpawnGeometric();
        score.ScoreCount(gameObject.tag);
    }
    
}

