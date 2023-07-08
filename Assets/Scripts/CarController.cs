using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class CarController : MonoBehaviour
{
    [SerializeField] private WheelCollider[] frontWheels;
    [SerializeField] private WheelCollider[] rearWheels;
    [SerializeField] private float power;

    private Vector2 movement; 
    // Start is called before the first frame update
    void Start()
    {
        var rb = GetComponent<Rigidbody>();
        rb.centerOfMass = new Vector3 (0, -0.5f, -0.2f);
    }

    // Update is called once per frame
    void Update()
    {
    }

    private void FixedUpdate() {

        foreach(var wheel in rearWheels) {
            wheel.motorTorque = movement.y * power;
        }
        foreach(var wheel in frontWheels) {
            wheel.steerAngle = movement.x * 15;
        }
    }

    private void OnSteer(InputValue value) {
        movement.x = value.Get<float>();
    }

    private void OnGasGasGas(InputValue value) {
        movement.y = value.Get<float>();
    }
}
