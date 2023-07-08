using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    [SerializeField] private Transform cam;
    [SerializeField] private Transform car;

    void Start()
    {
        Screen.orientation = ScreenOrientation.LandscapeLeft;
    }

    void LateUpdate()
    {
        cam.position = car.position;
        cam.rotation = Quaternion.Euler(0, car.rotation.eulerAngles.y, 0);
        
    }
}
