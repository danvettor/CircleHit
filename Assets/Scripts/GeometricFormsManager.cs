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
		print ("Tamanho do sprite width: " + circleRenderer.bounds.extents.x + "height" + circleRenderer.bounds.extents.x);

		circle = (GameObject) Instantiate(circlePrefab, Vector3.zero, Quaternion.identity);

		circleRenderer = circle.GetComponent<Renderer>();


		circleScale = Random.Range(0.2f,1.0f);
		circle.transform.localScale = new Vector3(circleScale,circleScale,1);
		circleX = Random.Range(circleRenderer.bounds.extents.x, (Screen.width*2/100.0f) - circleRenderer.bounds.extents.x);
		circleY = Random.Range(circleRenderer.bounds.extents.y, (Screen.height*2/100.0f) - circleRenderer.bounds.extents.y);
		circlePosition = new Vector3(circleX, circleY,0);

		circle.transform.position = circlePosition;
	}




}
