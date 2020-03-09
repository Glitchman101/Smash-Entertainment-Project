using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerGravity : MonoBehaviour
{
    public ConstantForce gravity;

    // Start is called before the first frame update
    void Start()
    {
        gravity = gameObject.AddComponent<ConstantForce>();
        gravity.force = new Vector3(0.0f, -9.81f, 0.0f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
