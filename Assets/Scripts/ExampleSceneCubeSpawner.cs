using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExampleSceneCubeSpawner : MonoBehaviour
{
    private int count = 0;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (count >= 300)
        {
            count = 0;
          var g=  GameObject.CreatePrimitive(PrimitiveType.Cube);
          g.transform.position = transform.position;
          g.transform.rotation=new Quaternion(Random.Range(0.0f,1.0f),Random.Range(0.0f,1.0f),Random.Range(0.0f,1.0f),Random.Range(0.0f,1.0f));
          g.AddComponent<ExampleSceneCube>();

        }

        count++;
    }
}