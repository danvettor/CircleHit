using UnityEngine;
using System.Collections;
using UnityEngine.UI;


public class GeometricFormsManager : MonoBehaviour {
	[SerializeField]
	private GameObject circlePrefab;
	private GameObject circleObject;

    [SerializeField]
    private GameObject fakeCirclePrefab;
    private GameObject fakeCircleObject;

    private Vector2 circlePosition;
    private Vector2 fakeCirclePosition;

	[SerializeField]
	private Renderer circleRenderer;
    [SerializeField]
    private Renderer fakeCircleRenderer;

    [SerializeField]
	private ProgressBarManagement barManagement;

	private float circleX, circleY, circleScale;
    private float fakeCircleX, fakeCircleY, fakeCircleScale;

    private float minX,maxX,minY,maxY;
    private float fminX, fmaxX, fminY, fmaxY;
    private Vector3 screenSize;

	
	public void DestroyCircle(GameObject circle)
	{
		Destroy(circle);
		barManagement.IncreaseBar(0.1f);
		SpawnCircle();
		screenSize = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height,0.0f));

	}


    public void DestroyFakeCircle(GameObject fakeCircle)
    {
        Destroy(fakeCircle);
        barManagement.DecreaseBar(0.1f);
        SpawnFakeCircle();
        screenSize = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, 0.0f));

    }
	public void SpawnCircle()
	{
		print ("Tamanho da tela :(h: " + Screen.height +", w: "+ Screen.width+")");
	
		circleObject = (GameObject) Instantiate(circlePrefab, Vector3.zero, Quaternion.identity);

	
		circleScale = Random.Range(0.2f,1.0f);
		circleObject.transform.localScale = new Vector3(circleScale,circleScale,1);
		circleRenderer = circleObject.GetComponent<Renderer>();

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

		circleObject.transform.position = new Vector3(circlePosition.x,circlePosition.y,0);
	}


    public void SpawnFakeCircle()
    {
        print("Tamanho da tela :(h: " + Screen.height + ", w: " + Screen.width + ")");

        fakeCircleObject = (GameObject) Instantiate(fakeCirclePrefab, Vector3.zero, Quaternion.identity);


        fakeCircleScale = Random.Range(0.3f, 2.0f);
        fakeCircleObject.transform.localScale = new Vector3(fakeCircleScale, fakeCircleScale, 1);
        fakeCircleRenderer = fakeCircleObject.GetComponent<Renderer>();

        print("Tamanho do sprite width: " + fakeCircleRenderer.bounds.extents.magnitude + "height" + fakeCircleRenderer.bounds.extents.x);

        fminX = -screenSize.x + fakeCircleRenderer.bounds.extents.x / 2;
        fmaxX = screenSize.x - fakeCircleRenderer.bounds.extents.x / 2;
        fminY = -screenSize.y + fakeCircleRenderer.bounds.extents.x / 2;
        fmaxY = screenSize.y - fakeCircleRenderer.bounds.extents.x / 2;

        fakeCircleX = Random.Range(fminX, fmaxX);
        fakeCircleY = Random.Range(fminY, fmaxY);

        //circlePosition = Camera.main.ScreenToWorldPoint(new Vector3(circleX, circleY,0.0f));
        fakeCirclePosition = new Vector3(fakeCircleX, fakeCircleY, 0.0f);

        print("posicao escolhida: " + fakeCirclePosition);

        fakeCircleObject.transform.position = new Vector3(fakeCirclePosition.x, fakeCirclePosition.y, 0);
    }
	


}
