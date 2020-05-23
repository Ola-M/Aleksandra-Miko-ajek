using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class skrypt : MonoBehaviour
{
    public float cube;
    public float cube1;
    public float cube2;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(cube, cube1, cube2);
        
    }
}
