using UnityEngine;

public class SpawnImages : MonoBehaviour
{
    [SerializeField] private GameObject image;
    [SerializeField] private Material[] materials;

    void Start()
    {
        for (float i = 1.2f; i <= 6.8f; i += 2.8f)
        {
            for (float j = 1.2f; j <= 6.8f; j += 2.8f)
            {
                Vector3 localPosition = new Vector3(i, 0.1f, j);
                Vector3 worldPosition = transform.TransformPoint(localPosition);
                GameObject newImage = Instantiate(image, worldPosition, transform.rotation, transform);

                MeshRenderer meshRenderer = newImage.GetComponent<MeshRenderer>();
                if (meshRenderer != null)
                {
                    meshRenderer.material = materials[Random.Range(0, materials.Length)];
                }
            }
        }
    }
}
