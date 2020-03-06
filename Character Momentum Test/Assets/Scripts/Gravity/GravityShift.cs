using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GravityShift : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
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
