using UnityEngine;

public class DistractingCube : MonoBehaviour
{
    public float speed = 10f;  // Speed of the cube

    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.useGravity = false;

        // Apply an initial random velocity
        Vector3 randomDirection = Random.insideUnitSphere.normalized;
        rb.linearVelocity = randomDirection * speed;
    }

    void OnCollisionEnter(Collision collision)
    {
        // Reflect the velocity based on the collision normal
        Vector3 reflectedVelocity = Vector3.Reflect(rb.linearVelocity, collision.contacts[0].normal);
        rb.linearVelocity = reflectedVelocity.normalized * speed;  // Maintain the speed after reflection
    }

    void Update()
    {
        // Maintain constant speed to prevent any slowdowns over time
        rb.linearVelocity = rb.linearVelocity.normalized * speed;
    }
}
