using UnityEngine;

public class ImageClickHandler : MonoBehaviour
{
    [SerializeField] SpawnImages spawnScript;
    [SerializeField] AudioClip correct;
    [SerializeField] AudioClip incorrect;
    AudioSource audioSource;
    Vector3 prevImagePos;
    Quaternion prevImageRot;
    Transform prevImageParent = null;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

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
                        audioSource.clip = correct;
                        audioSource.Play();
                        Destroy(hit.collider.gameObject);
                    }
                    else
                    {
                        StaticData.ChangePoints(-1);
                        audioSource.clip = incorrect;
                        audioSource.Play();
                        Destroy(hit.collider.gameObject);
                    }

                    if (prevImageParent != null)
                    {
                        spawnScript.SpawnImage(prevImagePos, prevImageRot, prevImageParent);

                        prevImagePos = clickedObject.transform.position;
                        prevImageRot = clickedObject.transform.rotation;
                        prevImageParent = clickedObject.transform.parent;
                    }
                    else
                    {
                        prevImagePos = clickedObject.transform.position;
                        prevImageRot = clickedObject.transform.rotation;
                        prevImageParent = clickedObject.transform.parent;
                    }
                }

                if (clickedObject.CompareTag("Distraction"))
                {
                    StaticData.ChangePoints(-3);
                    audioSource.clip = incorrect;
                    audioSource.Play();
                }
            }
        }
    }
}
