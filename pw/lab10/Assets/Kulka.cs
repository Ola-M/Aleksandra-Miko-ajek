﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kulka : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed;
    public Material[] kolor;
    public GameObject tak;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxis("Horizontal") * Time.deltaTime * speed;
        float y = Input.GetAxis("Vertical") * Time.deltaTime * speed;
        transform.Translate(x,y,0);


        if (Input.GetMouseButtonDown(0))
        {
            int los = Random.Range(0, kolor.Length);
            tak.transform.GetComponent<Renderer>().material = kolor[los];
            Vector3 pozycja = Input.mousePosition;
            pozycja.z = 15f;
            pozycja = Camera.main.ScreenToWorldPoint(pozycja);
            Instantiate(tak, pozycja, Quaternion.identity);
        }
    }
}