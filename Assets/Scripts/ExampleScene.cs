using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExampleScene : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        var a = GetComponent<Transform>();
        a.position += new Vector3(0, 0, 0.1f);
    }

    void RedundantFunction()
    {
        int a = 10;
        a += 5;
        int b = a;
    }
}
