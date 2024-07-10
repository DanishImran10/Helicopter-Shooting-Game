using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletScript : MonoBehaviour
{
    GameObject me;

    // Start is called before the first frame update
    void Start()
    {
        me = GameObject.Find("Helicopter");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        transform.Translate(0, 0, 5);

        Vector3 v = transform.position;
        if (v.x < -2500 || v.x > 2500 || v.z < -2500 || v.z > 2500)
            GameObject.Destroy(transform.gameObject);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.name.StartsWith("Enemy"))
            me.GetComponent<HelicopterScript>().score += 5;

        if(collision.gameObject.name != "Helicopter")
            GameObject.Destroy(transform.gameObject);
    }
}
