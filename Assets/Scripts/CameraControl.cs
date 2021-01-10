using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour
{
    public float sensitivityVertical = 9.0f;

    public float minimumVertical = -45.0f;
    public float maximumVertical = 45.0f;

    private float rotationX = 0;

    void Update()
    {
        rotationX -= Input.GetAxis("Mouse Y") * sensitivityVertical;
        rotationX = Mathf.Clamp(rotationX, minimumVertical, maximumVertical);

        transform.localEulerAngles = new Vector3(rotationX, 0, 0);
    }
}
