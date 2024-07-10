using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootingRangeScript : MonoBehaviour
{
    GameObject me;
    public GameObject muzzle;
    public GameObject shellprefab;

    // Start is called before the first frame update
    void Start()
    {
        me = GameObject.Find("Helicopter");
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name.StartsWith("Helicopter"))
            GameObject.Instantiate(shellprefab, muzzle.transform.position, muzzle.transform.rotation);
    }
}
