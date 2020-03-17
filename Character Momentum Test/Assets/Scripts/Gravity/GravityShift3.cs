using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GravityShift3 : MonoBehaviour
{
    private float x = -9.81f;
    private float y;
    private float z;

    private float x2;
    private float y2;
    private float z2;

    private float rX;
    private float rY;
    private float rZ = -90;

    public GameObject Player;
  
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            Player.GetComponent<ConstantForce>().force = new Vector3(x, y, z);
            Player.transform.rotation = Quaternion.Euler(rX, rY, rZ);
        } 
    }
    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            Player.GetComponent<ConstantForce>().force = new Vector3(x2, y2, z2);
        }
    }

}
