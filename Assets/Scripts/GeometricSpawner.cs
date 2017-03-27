using UnityEngine;
using System.Collections;
using System;

public class GeometricSpawner : MonoBehaviour {
	private Circle fakeCircle; 
	private Circle circle;

	public int numBlueCircles;
	public int numRedCircles;
	void Awake(){
		numBlueCircles = 0;
		numRedCircles = 0;
		Invoke("CountCircles",2.0f);
		Invoke("CountCircles",6.0f);
	}
	void CountCircles()
	{
		Debug.Log("red: "+ numRedCircles);

		Debug.Log("blue: "+ numBlueCircles);

		Debug.Log("=====================================");
	}
	/*void Awake()
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

	*/
}
