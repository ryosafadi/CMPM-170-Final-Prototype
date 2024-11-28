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
                    StaticData.PointScored();
                    Destroy(hit.collider.gameObject);
                }
            }
        }
    }
}
