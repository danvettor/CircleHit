using UnityEngine;
using System.Collections;

public class GeometricSpawner : MonoBehaviour {

    [SerializeField]
    private GameObject circlePrefab;
    [SerializeField]
    private GameObject fakeCirclePrefab;

    private Vector2 circlePosition;
    private Vector2 fakeCirclePosition;

    public Transform canvas;

    private float circleX, circleY, circleScale;
    private float fakeCircleX, fakeCircleY, fakeCircleScale;

    private float minX, maxX, minY, maxY;
    private float fminX, fmaxX, fminY, fmaxY;
    private Vector3 screenSize;
    

    public void SpawnGeometric()
    {
        var circleObject = (GameObject)Instantiate(circlePrefab, Vector3.zero, Quaternion.identity);

        circleObject.transform.SetParent(canvas);
        circleScale = Random.Range(0.2f, 1.0f);
        circleObject.transform.localScale = new Vector3(circleScale, circleScale, 1);
    
        var circleBounds = circleObject.GetComponent<RectTransform>().rect.width;
        minX = -screenSize.x + circleBounds / 2;
        maxX = screenSize.x - circleBounds / 2;
        minY = -screenSize.y + circleBounds / 2;
        maxY = screenSize.y - circleBounds / 2;

        circleX = Random.Range(minX, maxX);
        circleY = Random.Range(minY, maxY);

        //circlePosition = Camera.main.ScreenToWorldPoint(new Vector3(circleX, circleY,0.0f));
        circlePosition = new Vector3(circleX, circleY, 0.0f);

        print("posicao escolhida: " + circlePosition);

        circleObject.transform.position = new Vector3(circlePosition.x, circlePosition.y, 0);
    }


    public void SpawnFakeCircle()
    {
      
        var fakeCircleObject = (GameObject)Instantiate(fakeCirclePrefab, Vector3.zero, Quaternion.identity);

        fakeCircleObject.transform.SetParent(canvas);

        fakeCircleScale = Random.Range(0.3f, 2.0f);
        fakeCircleObject.transform.localScale = new Vector3(fakeCircleScale, fakeCircleScale, 1);
        var fakeCircleBounds = fakeCircleObject.GetComponent<RectTransform>().rect.width;

       
        fminX = -screenSize.x + fakeCircleBounds / 2;
        fmaxX = screenSize.x - fakeCircleBounds / 2;
        fminY = -screenSize.y + fakeCircleBounds/2;
        fmaxY = screenSize.y - fakeCircleBounds / 2;

        fakeCircleX = Random.Range(fminX, fmaxX);
        fakeCircleY = Random.Range(fminY, fmaxY);

        //circlePosition = Camera.main.ScreenToWorldPoint(new Vector3(circleX, circleY,0.0f));
        fakeCirclePosition = new Vector3(fakeCircleX, fakeCircleY, 0.0f);

        print("posicao escolhida: " + fakeCirclePosition);

        fakeCircleObject.transform.position = new Vector3(fakeCirclePosition.x, fakeCirclePosition.y, 0);
    }

}
