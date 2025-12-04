using UnityEngine;

public class jump : MonoBehaviour
{
    public Rigidbody rb;
    public float force = 100f;   // lực bắn

    

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }



    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Shoot();
        }
    }

    void Shoot()
    {
        rb.useGravity = true;
        rb.linearVelocity = Vector3.zero;

        // Bắn thẳng theo hướng transform.forward
        rb.AddForce(transform.forward * force, ForceMode.Impulse);
    }
}
