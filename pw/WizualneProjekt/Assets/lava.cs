using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lava : MonoBehaviour
{
  public GameObject kulka;


    

    void Start()
    {
    
        InvokeRepeating("GenerateObject", 4f, 1f);
    }

    
    void Update()
    {
       
       
    }

    void GenerateObject()
    {
        float Valuex = Random.Range(-900, 900);
        float Valuey = Random.Range(-900, 900);
        GameObject bum = Instantiate(kulka, transform.position, Quaternion.identity);
        bum.GetComponent<Rigidbody>().AddForce(new Vector3(Valuex,900f,Valuey));
    }
}
