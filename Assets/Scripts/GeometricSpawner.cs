﻿using UnityEngine;
using System.Collections;
using System;

public class GeometricSpawner : MonoBehaviour {

    [SerializeField]
    private GameObject circleObject;
    [SerializeField]
    private GameObject fakeCircleObject;

    private Vector2 circlePosition;
    private Vector2 fakeCirclePosition;
    

    private float circleX, circleY, circleScale;
    private float fakeCircleX, fakeCircleY, fakeCircleScale;

    public void SpawnGeometric()
    {
        SpawnCircle();
        SpawnFakeCircle();
    }
    void SpawnCircle()
    {
        var circleScale = UnityEngine.Random.Range(0.05f, 0.4f);
        circleObject.transform.localScale = new Vector3(circleScale, circleScale, 1);
        var circleBounds = circleObject.GetComponent<RectTransform>().rect.width;

        var minX  = circleBounds / 2;
        var maxX = Screen.width - minX;
        var minY = minX;
        var maxY = Screen.height - minY;

        var circlePosition = new Vector3(UnityEngine.Random.Range(minX, maxX), UnityEngine.Random.Range(minY, maxY), 0.0f);

        //playu na animacao de pop
        print("posicao escolhida: " + circlePosition);

        circleObject.GetComponent<RectTransform>().position = circlePosition;


    }
    void SpawnFakeCircle()
    {
        var circleScale = UnityEngine.Random.Range(0.05f, 0.4f);
        fakeCircleObject.transform.localScale = new Vector3(circleScale, circleScale, 1);
        var circleBounds = fakeCircleObject.GetComponent<RectTransform>().rect.width;

        var minX = circleBounds / 2;
        var maxX = Screen.width;
        var minY = minX;
        var maxY = Screen.height;


        var rnd = new System.Random();  
//       var circlePosition = new Vector3(Random.Range(minX, maxX), Random.Range(minY, maxY), 0.0f);
        var circlePosition = new Vector3(rnd.Next((int)maxX), rnd.Next((int)maxY), 0.0f);
        //playu na animacao de pop
        print("posicao escolhida: " + circlePosition);

        fakeCircleObject.GetComponent<RectTransform>().position = circlePosition;


    }

}
