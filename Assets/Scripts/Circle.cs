using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;
using Numeric;

public class Circle : MonoBehaviour
{

    private GeometricSpawner spawner;
    private Score score;
    private RectTransform rect;
    private Animator anim;

    private IEnumerator coroutineInstance;

    void Awake()
    {
        //trocar isso posteriormente

        spawner = GameObject.FindGameObjectWithTag("Spawner").GetComponent<GeometricSpawner>();
        score = GameObject.FindGameObjectWithTag("Score").GetComponent<Score>();
        rect = GetComponent<RectTransform>();
        anim = GetComponent<Animator>();
        
    }
    public void TouchResponse()
    {
        //   spawner.SpawnGeometric();

        if (!(coroutineInstance == null))
        {
            StopCoroutine(coroutineInstance);
        }
        Respawn();

    }
    public void Respawn()
    {

        var circleBounds = rect.rect.width;

        var minX = 0;
        var maxX = Screen.width;
        var minY = minX;
        var maxY = Screen.height;

        var circlePosition = new Vector3(RandomNumber.Between(minX, maxX), UnityEngine.Random.Range(minY, maxY), 0.0f);
        
        print("posicao escolhida: " + circlePosition);
        coroutineInstance = ShowCircle();
        StartCoroutine(coroutineInstance);
        
        rect.position = circlePosition;
    }
    IEnumerator ShowCircle()
    {
        var circleScale = UnityEngine.Random.Range(0.05f, 0.4f);
        var newScale = new Vector3(circleScale, circleScale, 1);
        transform.localScale = Vector3.zero;

        while (true)
        {
            transform.localScale = Vector3.Lerp(transform.localScale, newScale,0.05f);
            yield return new WaitForSeconds(0.005f);
        }
    }

}

