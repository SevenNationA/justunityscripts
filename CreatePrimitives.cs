using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreatePrimitives : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GameObject.CreatePrimitive(PrimitiveType.Cube).transform.position = new Vector3(4, 0, -4);
        GameObject.CreatePrimitive(PrimitiveType.Cube).transform.position = new Vector3(3.5f, 1, -4);
        GameObject.CreatePrimitive(PrimitiveType.Cube).transform.position = new Vector3(4.5f, 1, -4);
        GameObject.CreatePrimitive(PrimitiveType.Cube).transform.position = new Vector3(4.5f, 2, -4);
        GameObject.CreatePrimitive(PrimitiveType.Cube).transform.position = new Vector3(3.5f, 2, -4);
        GameObject.CreatePrimitive(PrimitiveType.Cube).transform.position = new Vector3(4, 3, -4);
        //create steve
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
