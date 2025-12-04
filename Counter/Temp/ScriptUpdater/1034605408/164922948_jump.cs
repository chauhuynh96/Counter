using UnityEngine;

public class jump : MonoBehaviour
{
    public Rigidbody rb;
    public float powerXZ = 0.02f;   // lực ngang + thẳng
    public float powerY = 0.02f;   // lực theo trục đứng (độ cao)

    private Vector3 dragStart;
    private Vector3 dragEnd;
    private bool dragging = false;

    void Update()
    {
        // Bắt đầu kéo chuột
        if (Input.GetMouseButtonDown(0))
        {
            dragStart = Input.mousePosition;
            dragging = true;
        }

        // Thả chuột -> ném bóng
        if (Input.GetMouseButtonUp(0) && dragging)
        {
            dragEnd = Input.mousePosition;
            dragging = false;

            ThrowBall(dragEnd - dragStart);
        }
    }

    void ThrowBall(Vector3 dragVector)
    {
        // dragVector.x  → kéo ngang  → Z
        // dragVector.y  → kéo lên    → Y
        // dragVector.magnitude → độ xa kéo → X

        Vector3 force = new Vector3(
            dragVector.magnitude * powerXZ,   // X = ném tới rổ
            dragVector.y * powerY,            // Y = độ cao
            dragVector.x * powerXZ            // Z = trái – phải
        );

        rb.useGravity = true;
        rb.linearVelocity = Vector3.zero;
        rb.AddForce(force, ForceMode.Impulse);
    }
}
