using UnityEngine;
using System.Collections;
using System;

public class GeometricSpawner : MonoBehaviour {
	private Circle fakeCircle; 
	private Circle circle;


	void Awake()
	{
		fakeCircle = transform.FindChild("FakeCircle").GetComponent<Circle>();
		circle = transform.FindChild("Circle").GetComponent<Circle>();
	}
	void Start()
	{
		fakeCircle.TouchResponse();
		circle.TouchResponse();
	}


    public void SpawnGeometric()
    {   
        fakeCircle.TouchResponse();
        circle.TouchResponse();
    }


}
