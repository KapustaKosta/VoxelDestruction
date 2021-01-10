using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    public float sensitivityHorizontal = 9.0f;

    public float speed = 1f;
    private CharacterController characterController;

    void Start()
    {
        characterController = this.GetComponent<CharacterController>();
        this.GetComponent<Rigidbody>().freezeRotation = true;
    }

    // Update is called once per frame
    void Update()
    {
        float delta = Input.GetAxis("Mouse X") * sensitivityHorizontal;
        float rotationY = transform.localEulerAngles.y + delta;

        transform.localEulerAngles = new Vector3(0, rotationY, 0);

        float deltaX = Input.GetAxis("Horizontal") * speed;
        float deltaZ = Input.GetAxis("Vertical") * speed;
        Vector3 movement = new Vector3(deltaX, 0, deltaZ);
        movement = Vector3.ClampMagnitude(movement, speed);

        movement.y = -9.8f;

        movement *= Time.deltaTime;
        movement = transform.TransformDirection(movement);
        characterController.Move(movement);
    }
}
