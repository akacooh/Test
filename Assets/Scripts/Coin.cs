using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    [SerializeField] private float rotationSpeed;
    [SerializeField] private Camera cam;
    [SerializeField] private Material[] materials;

    private Renderer render;
    private int currentMaterial = 0;

    private void Start() {
        render = GetComponent<Renderer>();
        render.material = materials[currentMaterial];
    }

    void Update()
    {
        transform.Rotate(Vector3.up, rotationSpeed * Time.deltaTime, Space.World);
        if ((Input.touchCount == 1) && (Input.GetTouch(0).phase == TouchPhase.Began)) {
            Ray ray = cam.ScreenPointToRay(Input.GetTouch(0).position);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit, 20f)) {
                if (hit.collider.tag == "Coin") ChangeColor();
            }
        }
    }

    private void ChangeColor() {
        currentMaterial++;
        if (currentMaterial == materials.Length) currentMaterial = 0;
        render.material = materials[currentMaterial];
    }
}
