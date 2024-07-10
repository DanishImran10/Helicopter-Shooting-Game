using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurretScript : MonoBehaviour
{
    GameObject me;
    //public GameObject shellprefab;

    // Start is called before the first frame update
    void Start()
    {
        me = GameObject.Find("Helicopter");
    }

    // Update is called once per frame
    private void Update()
    {
        
    }
    void FixedUpdate()
    {
        transform.LookAt(me.transform);
    }


}
