using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations;

public class BombScript : MonoBehaviour
{
    private Rigidbody r;
    GameObject me;
    // Start is called before the first frame update
    void Start()
    {
        r = transform.GetComponent<Rigidbody>();

        me = GameObject.Find("Helicopter");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        r.AddRelativeForce(new Vector3(0, 0, 5));
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name.StartsWith("Tank"))
            me.GetComponent<HelicopterScript>().score += 10;

        if (!collision.gameObject.name.StartsWith("Helicopter"))
            GameObject.Destroy(transform.gameObject);

    }
}
