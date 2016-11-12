using UnityEngine;
using System.Collections;
using System;

public class GeometricSpawner : MonoBehaviour {

    [SerializeField]
    private Circle circle;
    [SerializeField]
    private Circle fakeCircle;

    public void SpawnGeometric()
    {   
        fakeCircle.TouchResponse();
        circle.TouchResponse();
    }


}
