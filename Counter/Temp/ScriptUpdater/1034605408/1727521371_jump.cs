using UnityEngine;

public class jump : MonoBehaviour
{
    public Rigidbody rb;
    public float forwardPower = 5f;  // lực ném thẳng (X)
    public float upwardPower = 3f;   // lực nâng để tạo quỹ đạo cong (Y)

    private float holdTime = 0f;
    private bool holding = false;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            holdTime = 0f;
            holding = true;
        }

        if (holding)
        {
            holdTime += Time.deltaTime;
        }

        if (Input.GetMouseButtonUp(0) && holding)
        {
            ThrowBall();
            holding = false;
        }
    }

    void ThrowBall()
    {
        rb.useGravity = true;
        rb.linearVelocity = Vector3.zero;

        // Lực theo trục X + Y
        Vector3 force = new Vector3(
            holdTime * forwardPower,   // ném thẳng
            holdTime * upwardPower,    // tạo độ cong
            0                           // không lệch Z
        );

        rb.AddForce(force, ForceMode.Impulse);
    }
}
