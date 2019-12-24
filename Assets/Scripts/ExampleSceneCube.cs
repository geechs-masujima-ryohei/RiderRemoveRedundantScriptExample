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
        GetComponent<Renderer>().material.color = new Color(Random.value, Random.value, Random.value, 1.0f); ;

    }

    // Update is called once per frame
    void Update()
    {
        if (count >= 150+Random.Range(0,100))
        {
            count = 0;
            GetComponent<Renderer>().material.color = new Color(Random.value, Random.value, Random.value, 1.0f);
            
        }

        count++;
    }

    private void OnBecameInvisible()
    {
        Destroy(gameObject);
    }
}
