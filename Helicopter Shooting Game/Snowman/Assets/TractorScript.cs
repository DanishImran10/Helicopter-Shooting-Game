using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TractorScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Rigidbody r = transform.GetComponent<Rigidbody>();
            r.AddRelativeForce(new Vector3(0, 200, 0));
        }
    }

    private void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            Rigidbody r = transform.GetComponent<Rigidbody>();
            r.AddRelativeForce(new Vector3(0, 0, 30));
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            Rigidbody r = transform.GetComponent<Rigidbody>();
            r.AddRelativeForce(new Vector3(0, 0, -30));
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Rotate(new Vector3(0, -1, 0));
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Rotate(new Vector3(0, 1, 0));
        }
    }
}
