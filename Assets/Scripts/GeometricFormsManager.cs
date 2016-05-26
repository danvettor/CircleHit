using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GeometricFormsManager : MonoBehaviour {
	[SerializeField]
	private GameObject circlePrefab;
	private GameObject circle;

	private Vector2 circlePosition;
	[SerializeField]
	private Renderer circleRenderer;

	[SerializeField]
	private Image bar;

	private float circleX, circleY, circleScale;

	private float minX,maxX,minY,maxY;
	private Vector3 screenSize;

	
	public void DestroyCircle(GameObject circle)
	{
		Destroy(circle);
		bar.fillAmount += 0.1f;
		SpawnCircle();
		screenSize = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height,0.0f));
		print("Tamaanho da tela redimensionado" + screenSize);

	}
	public void SpawnCircle()
	{
		print ("Tamanho da tela :(h: " + Screen.height +", w: "+ Screen.width+")");
	
		circle = (GameObject) Instantiate(circlePrefab, Vector3.zero, Quaternion.identity);

	
		circleScale = Random.Range(0.2f,1.0f);
		circle.transform.localScale = new Vector3(circleScale,circleScale,1);
		circleRenderer = circle.GetComponent<Renderer>();

		print ("Tamanho do sprite width: " + circleRenderer.bounds.extents.magnitude + "height" + circleRenderer.bounds.extents.x);

		minX = -screenSize.x + circleRenderer.bounds.extents.x/2;
		maxX =  screenSize.x - circleRenderer.bounds.extents.x/2;
		minY = -screenSize.y + circleRenderer.bounds.extents.x/2;
		maxY =  screenSize.y - circleRenderer.bounds.extents.x/2;

		circleX = Random.Range(minX,maxX);
		circleY = Random.Range(minY,maxY);

		//circlePosition = Camera.main.ScreenToWorldPoint(new Vector3(circleX, circleY,0.0f));
		circlePosition = new Vector3(circleX, circleY,0.0f);

		print("posicao escolhida: " + circlePosition);

		circle.transform.position = new Vector3(circlePosition.x,circlePosition.y,0);
	}




}
