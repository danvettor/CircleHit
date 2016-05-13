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

	
	public void DestroyCircle(GameObject circle)
	{
		Destroy(circle);
		bar.fillAmount += 0.05f;
		SpawnCircle();
	}
	public void SpawnCircle()
	{
		print ("Tamanho da tela" + Screen.height);
	
		circle = (GameObject) Instantiate(circlePrefab, Vector3.zero, Quaternion.identity);

		circleRenderer = circle.GetComponent<Renderer>();


		circleScale = Random.Range(0.2f,1.0f);
		circle.transform.localScale = new Vector3(circleScale,circleScale,1);
		print ("Tamanho do sprite width: " + circleRenderer.bounds.extents.x + "height" + circleRenderer.bounds.extents.x);

		circleX = Random.Range(0,(Screen.width));
		circleY = Random.Range(0, (Screen.height));
		circlePosition = Camera.main.ScreenToWorldPoint(new Vector3(circleX, circleY,0.0f));

		circle.transform.position = new Vector3(circlePosition.x,circlePosition.y,0);
	}




}
