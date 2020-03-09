using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GravityShift : MonoBehaviour
{
    public float x = 0f;
    public float y = 0f;
    public float z = 0f;

    public float rX = 0;
    public float rY = 0;
    public float rZ = 0;

    public GameObject Player;
  
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            Physics.gravity = new Vector3(x, y, z);
            Player.transform.rotation = Quaternion.Euler(rX, rY, rZ);
        } 
    }

    private void GravShift()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            Physics.gravity = new Vector3(0, 9.8f, 0);
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            Physics.gravity = new Vector3(0, -9.8f, 0);

        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            Physics.gravity = new Vector3(9.8f, 0, 0);
            transform.rotation = Quaternion.Euler(0, 0, 90);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            Physics.gravity = new Vector3(-9.8f, 0, 0);
            transform.rotation = Quaternion.Euler(0, 0, -90);
        }
    }
}
