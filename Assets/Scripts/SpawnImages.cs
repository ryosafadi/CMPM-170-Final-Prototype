using UnityEngine;

public class SpawnImages : MonoBehaviour
{
    [SerializeField] private GameObject image;

    void Start()
    {
        Instantiate(image, new Vector3(6.8f, 0.1f, 6.8f), Quaternion.identity);
        /*
        Instantiate(image, new Vector3(6.8f, 0.1f, 4f), Quaternion.identity);
        Instantiate(image, new Vector3(6.8f, 0.1f, 1.2f), Quaternion.identity);
        Instantiate(image, new Vector3(4f, 0.1f, 6.8f), Quaternion.identity);
        Instantiate(image, new Vector3(4f, 0.1f, 4f), Quaternion.identity);
        Instantiate(image, new Vector3(4f, 0.1f, 1.2f), Quaternion.identity);
        Instantiate(image, new Vector3(1.2f, 0.1f, 6.8f), Quaternion.identity);
        Instantiate(image, new Vector3(1.2f, 0.1f, 4f), Quaternion.identity);
        Instantiate(image, new Vector3(1.2f, 0.1f, 1.2f), Quaternion.identity); */
    }
}
