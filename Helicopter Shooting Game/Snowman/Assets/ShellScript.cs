using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShellScript : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        transform.Translate(0, 0, 2.5f);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (!collision.gameObject.name.StartsWith("Tank"))
            GameObject.Destroy(transform.gameObject);
    }
}
