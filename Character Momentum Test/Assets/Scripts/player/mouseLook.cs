using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mouseLook : MonoBehaviour
{
    public float mouseSensitivty = 100f;

    public Transform playerBody;

    float xRotation = 0f;
    float yRotation = 0f;
    float zRotation = 0f;

    public float force = 1f;
    public GameObject Player;

    //public float force = 1f;
    //public GameObject Player;

    // Start is called before the first frame update
    private void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    private void Update()
    {
        RotateCamera();
    }

    private void RotateCamera()
    {
        float mouseX = Input.GetAxis("Mouse X") * mouseSensitivty * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * mouseSensitivty * Time.deltaTime;

        xRotation -= mouseY;
       
        xRotation = Mathf.Clamp(xRotation, -90f, 90f);

        transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f);
        playerBody.Rotate(Vector3.up * mouseX);

        if (Input.GetMouseButtonDown(0))
        {
            Vector3 pushDirection = transform.position;
            pushDirection = -pushDirection.normalized;
            Player.GetComponent<Rigidbody>().AddForce(pushDirection * force * xRotation * -100);
        }
    }
}
