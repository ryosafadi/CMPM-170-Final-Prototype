using UnityEngine;

public class ImageClickHandler : MonoBehaviour
{
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        
            if (Physics.Raycast(ray, out RaycastHit hit))
            {
                GameObject clickedObject = hit.collider.gameObject;

                if (clickedObject.CompareTag("Image"))
                {
                    Renderer renderer = clickedObject.GetComponent<Renderer>();

                    if (renderer.material.name.Contains("TrafficLight"))
                    {
                        StaticData.ChangePoints(1);
                        Destroy(hit.collider.gameObject);
                    }
                    else
                    {
                        StaticData.ChangePoints(-1);
                        Destroy(hit.collider.gameObject);
                    }
                }
            }
        }
    }
}
