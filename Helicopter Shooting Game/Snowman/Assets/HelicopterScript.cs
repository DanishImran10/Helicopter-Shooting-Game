using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class HelicopterScript : MonoBehaviour
{
    public GameObject bullet;
    public GameObject bomb;
    public GameObject enemyprefab;
    public GameObject tankprefab;
    public int score;
    public TextMeshProUGUI scoretext;

    // Start is called before the first frame update
    void Start()
    {
        score = 0;
        for (int i = 0; i < 20; i++)
        {
            GameObject.Instantiate(enemyprefab);
            GameObject.Instantiate(tankprefab);
        }
    }

    private void Update()
    {
        scoretext.text = "Score: " + score;
        if (Input.GetKeyDown(KeyCode.F))
        {
            GameObject.Instantiate(bullet, transform.position, transform.rotation);
        }
        if (Input.GetKeyDown(KeyCode.B))
        {
            GameObject.Instantiate(bomb, transform.position, transform.rotation);
        }
    }
    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            transform.GetComponent<Rigidbody>().AddRelativeForce(0, 50, 0);
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.GetComponent<Rigidbody>().AddRelativeForce(0, 0, 10);
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.GetComponent<Rigidbody>().AddRelativeForce(0, 0, -10);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Rotate(0, 1.5f, 0);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Rotate(0, -1.5f, 0);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name.StartsWith("Enemy") || collision.gameObject.name.StartsWith("Shell"))
        {
            SceneManager.LoadScene("GameOverScene");
        }
    }
}