using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class TankScript : MonoBehaviour
{
    GameObject me;
    public GameObject explosionprefab;

    // Start is called before the first frame update
    void Start()
    {
        me = GameObject.Find("Helicopter");

        Vector3 v = transform.position;
        v.x = Random.Range(-1200, 1200);
        v.y = 0;
        v.z = Random.Range(-1200, 1200);
        transform.position = v;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 pos = transform.position;
        while(pos.y < 0)
        {
            pos.x = Random.Range(-1200, 1200);
            pos.y = 0;
            pos.z = Random.Range(-1200, 1200);
        }
        transform.position = pos;
    }

    private void FixedUpdate()
    {
        Vector3 v = me.transform.position;
        v.y = 0;
        transform.LookAt(v);
        transform.Translate(0, 0, 0.5f);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.name.StartsWith("Bomb"))
        {
            GameObject.Instantiate(explosionprefab, transform.position, transform.rotation);

            Vector3 v = transform.position;
            v.x = Random.Range(-1200, 1200);
            v.y = 0;
            v.z = Random.Range(-1200, 1200);
            transform.position = v;
        }
    }
}
