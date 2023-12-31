using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Submarine_controller : MonoBehaviour
{
    public float speed = 0.5f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("w"))
            transform.Translate(Vector3.forward * speed * Time.fixedDeltaTime);

        if (Input.GetKey("d"))
            transform.Rotate(0.0f, +0.5f, 0.0f);

        if (Input.GetKey("a"))
            transform.Rotate(0.0f, -0.5f, 0.0f);
    }
}
