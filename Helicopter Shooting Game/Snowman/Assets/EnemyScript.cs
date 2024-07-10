using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour
{
    GameObject me;
    public GameObject explosionprefab;

    // Start is called before the first frame update
    void Start()
    {
        me = GameObject.Find("Helicopter");

        Vector3 v = transform.position;
        v.x = Random.Range(-1200, 1200);
        v.z = Random.Range(-1200, 1200);
        transform.position = v;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name.StartsWith("Bullet"))
        {
            GameObject.Instantiate(explosionprefab, transform.position, transform.rotation);

            Vector3 v = transform.position;
            v.x = Random.Range(-1200, 1200);
            v.z = Random.Range(-1200, 1200);
            transform.position = v;
        }
        if(collision.gameObject.name.StartsWith("Helicopter"))
        {
            Vector3 v = transform.position;
            v.x = Random.Range(-1200, 1200);
            v.z = Random.Range(-1200, 1200);
            transform.position = v;
        }
    }

    void FixedUpdate()
    {
        transform.LookAt(me.transform);
        transform.Translate(0, 0, 0.5f);
    }
}
