using UnityEngine;
using System.Collections;
using System.Collections.Generic;

using UnityEngine.UI;
using System;
using Numeric;

public class Circle : MonoBehaviour
{
    private GeometricSpawner spawner;
    private Score score;
    private RectTransform rect;
    private Animator anim;
	private List<CircleType> typeList;
	private CircleType circleType;

    private IEnumerator coroutineInstance;

    void Awake()
    {
        //trocar isso posteriormente
		
		typeList = new List<CircleType>{CircleType.Blue, CircleType.Red};
	
        spawner = GameObject.FindGameObjectWithTag("Spawner").GetComponent<GeometricSpawner>();
        score = GameObject.FindGameObjectWithTag("Score").GetComponent<Score>();
       
    }
	void Start()
	{
		//FAZER A ANIMAÇAO DE SHOW TOCAR AQUI
		var index = UnityEngine.Random.Range(0,typeList.Count);
		circleType = typeList[index];
		if(circleType == CircleType.Blue)
		{
			GetComponent<Image>().color = CircleColor.Blue;
			spawner.numBlueCircles++;
		}
		else
		{
			GetComponent<Image>().color = CircleColor.Red;
			spawner.numRedCircles++;
		}
	}
    public void TouchResponse()
    {
		//FAZER A ANIMAÇÃO DE HIDE/DESTROY DO CIRCULO TOCAR AQUI
		if (circleType == CircleType.Blue)
		{
			spawner.numBlueCircles--;
			score.WinScore();
		}
		else
		{
			spawner.numRedCircles--;
			score.LoseScore();
		}
	}
 

}
public enum CircleType 
{	
	Blue,
	Red
}

public class CircleColor
{
	public static Color Red 
	{
		get
		{
			return new Color(0.643137255f, 0.06666666666f, 0.06666666666f);
		}
		private set{}
	}

	public static Color Blue 
	{
		get
		{
			return new Color(0.06666666666f, 0.06666666666f, 0.643137255f);
		}
		private set{}
	}


}


