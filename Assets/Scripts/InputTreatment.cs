using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class InputTreatment : MonoBehaviour {
    private Vector3
        mousePosition,
        touchPosition;
    private RaycastHit hit;
    private Touch touch;
    [SerializeField]
    private GeometricFormsManager geometricHandler;

    [SerializeField]
    private ProgressBarManagement barManagement;


    void Update()
    {
        MouseInput();
    }

    void MouseInput()
    {
        if (Input.GetMouseButtonDown(0))
        {
            mousePosition = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, 0));
            Ray mouseRay = new Ray(mousePosition, Vector3.forward);
            if (Physics.Raycast(mouseRay, out hit))
            {
                if (hit.collider.CompareTag("Circle"))
                {
                    geometricHandler.DestroyCircle(hit.collider.gameObject);
                }

                else if (hit.collider.CompareTag("FakeCircle"))
                {
                    geometricHandler.DestroyFakeCircle(hit.collider.gameObject);
                }
            }
            else
            {
                barManagement.DecreaseBar(0.05f);
            }
        }

     
    }


    void TouchInput()
    {

        if (Input.GetTouch(0).phase == TouchPhase.Began)
        {
            touch = Input.GetTouch(0);
            touchPosition = Camera.main.ScreenToWorldPoint(new Vector3(touch.position.x, touch.position.y, 0));
            Ray touchRay = new Ray(touchPosition, Vector3.forward);
            if (Physics.Raycast(touchRay, out hit))
            {
                if (hit.collider.CompareTag("Circle"))
                {
                    geometricHandler.DestroyCircle(hit.collider.gameObject);
                }

                else if (hit.collider.CompareTag("FakeCircle"))
                {
                    geometricHandler.DestroyFakeCircle(hit.collider.gameObject);
                }
            }

            else
            {
                print("nao achei nada");
            }
        }

    }
}



