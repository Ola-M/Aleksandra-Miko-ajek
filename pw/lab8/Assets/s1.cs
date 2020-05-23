using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class s1 : MonoBehaviour   
{
    GameObject[] game;
    
    // Start is called before the first frame update
    void Start()
    {

        game = GameObject.FindGameObjectsWithTag("kula");
        foreach(GameObject s in game)
        {
            Destroy(s.gameObject);
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
