using UnityEngine;

public class SimpleCarController : MonoBehaviour
{
    public float motorForce = 1500f;
    public float steerAngle = 30f;

    public WheelCollider frontLeft, frontRight;
    public WheelCollider rearLeft, rearRight;

    void FixedUpdate()
    {
        float motor = motorForce * Input.GetAxis("Vertical");
        float steer = steerAngle * Input.GetAxis("Horizontal");

        frontLeft.steerAngle = steer;
        frontRight.steerAngle = steer;

        rearLeft.motorTorque = motor;
        rearRight.motorTorque = motor;
    }
}


