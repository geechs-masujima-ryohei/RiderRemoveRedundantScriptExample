using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExampleSceneCube : MonoBehaviour
{
    private int count = 0;
    // Start is called before the first frame update
    void Start()
    {
        gameObject.AddComponent<Rigidbody>();
        gameObject.AddComponent<BoxCollider>();
        GetComponent<Renderer>().material.color = new Color(Random.value, Random.value, Random.value, 1.0f);
        tag = "Cube";

    }

    // Update is called once per frame
    void Update()
    {
        if (count >= 150+Random.Range(0,100))
        {
            count = 0;
            GetComponent<Rigidbody>().AddForce(Vector3.up*100);
        }

        count++;
    }

    private void OnBecameInvisible()
    {
        Destroy(gameObject);
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Cube")
        {
            GetComponent<Renderer>().material.color = new Color(Random.value, Random.value, Random.value, 1.0f);
        }
    }
}
