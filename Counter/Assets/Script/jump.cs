using UnityEngine;

public class jump : MonoBehaviour
{
    public Rigidbody rb;
    public float force;   // lực bắn

    private float mouseDownTime;
    private float holdDuration;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }



    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            mouseDownTime = Time.time;
            Debug.Log("Nhan chuot");
        }
        if (Input.GetMouseButtonUp(0))
        {
            holdDuration = Time.time - mouseDownTime;
            force = holdDuration*2000;
            Debug.Log("Nha chuot");
            Shoot();
        }

    }

    void Shoot()
    {
        rb.useGravity = true;
        rb.linearVelocity = Vector3.zero;
        //force = 100f;
        // Bắn thẳng theo hướng transform.forward
        rb.AddForce(-transform.right * force, ForceMode.Impulse);
    }
}
