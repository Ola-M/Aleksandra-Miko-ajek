using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateObject : MonoBehaviour
{
  



    public GameObject[] kulka;

    

    void Start()
    {
        InvokeRepeating("GenerateObject", 4f, 3f);
    }

    
    void Update()
    {
        
        
        if(Input.GetKeyDown(KeyCode.Return))
        {
            CancelInvoke("GenerateObject");
        }
        if(Input.GetKeyDown(KeyCode.Alpha1))
        {
             Instantiate(kulka[0].gameObject, transform.position, Quaternion.identity);
        }
        if(Input.GetKeyDown(KeyCode.Alpha2))
        {
            Instantiate(kulka[1].gameObject, transform.position, Quaternion.identity);
        }
        if(Input.GetKeyDown(KeyCode.Alpha3))
        {
             Instantiate(kulka[2].gameObject, transform.position, Quaternion.identity);
        }
         if(Input.GetKeyDown(KeyCode.Alpha4))
        {
            Instantiate(kulka[3].gameObject, transform.position, Quaternion.identity); 
        }
         if(Input.GetKeyDown(KeyCode.Alpha5))
        {
             Instantiate(kulka[4].gameObject, transform.position, Quaternion.identity);
        }
         if(Input.GetKeyDown(KeyCode.Space))
        {
            GenerateObject();
        }
       
    }

    void GenerateObject()
    {
        int los = Random.Range(0, kulka.Length);
        Instantiate(kulka[los].gameObject, transform.position, Quaternion.identity);
    }
}
 
   

