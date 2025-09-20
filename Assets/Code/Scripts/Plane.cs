using System;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Plane : MonoBehaviour
{
    public float speed = 10f; // Speed of the plane

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Move the plane forward every frame
        transform.Translate(Vector3.back * (speed * Time.deltaTime));
    }

    private void OnTriggerEnter(Collider other)
    {
        SceneManager.LoadScene("Scenes/Start");
    }
}
