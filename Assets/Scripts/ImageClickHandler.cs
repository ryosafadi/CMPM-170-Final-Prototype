using UnityEngine;

public class ImageClickHandler : MonoBehaviour
{
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit))
            {
                GameObject clickedImage = hit.collider.gameObject;

                if (clickedImage.CompareTag("Image"))
                {
                    HandleImageClick(clickedImage);
                }
            }
        }
    }

    void HandleImageClick(GameObject image)
    {
        Destroy(image);
    }
}
