using UnityEngine;

public class CarControl : MonoBehaviour
{
    public float Movespeed = 25f;
    public float Turnspeed = 0.8f;
    public Rigidbody rb = null;

    private void FixedUpdate()
    {
        float vert = Input.GetAxis("Vertical");     // wasd, arrows, left-analog gamepad
        float horz = Input.GetAxis("Horizontal");   // -1..0..1

        rb.AddRelativeForce(Vector3.forward * vert * Movespeed, ForceMode.Acceleration);
        rb.AddRelativeTorque(Vector3.up * horz * Turnspeed, ForceMode.VelocityChange);
    }
}
