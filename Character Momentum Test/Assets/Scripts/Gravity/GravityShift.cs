using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GravityShift : MonoBehaviour
{
    float x;
    public float y = 0f;
    float z;

    public float x2 = 0f;
    public float y2 = 0f;
    public float z2 = 0f;

    public float rX = 0;
    public float rY = 0;
    public float rZ = 0;

    public float rX2 = 0f;
    public float rY2 = 0f;
    public float rZ2 = 0f;

    public GameObject Player;
  
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            Player.GetComponent<ConstantForce>().force = new Vector3(x, y, z);
            Player.transform.rotation = Quaternion.Euler(rX, rY, rZ);
        } 
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            Player.GetComponent<ConstantForce>().force = new Vector3(x2, y2, z2);
            Player.transform.rotation = Quaternion.Euler(rX2, rY2, rZ2);
        }
    }

}
