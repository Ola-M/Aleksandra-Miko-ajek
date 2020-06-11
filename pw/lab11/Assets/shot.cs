using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shot : MonoBehaviour
{
    Rigidbody fiz;
    public float speed;
    float inputX, inputZ;
    bool jump = false;
    bool shots = false;
    public GameObject bullet;
    public Transform bulletposition;
    void Awake()
    {
        fiz = GetComponent<Rigidbody>();
    }

    // Start is called before the first frame update
    void Start()
    {
        //fiz.velocity = new Vector3(0, 0, speed);
    }

    // Update is called once per frame
    void Update()
    {
        inputX = Input.GetAxis("Horizontal"); 
        inputZ = Input.GetAxis("Vertical");
        if(Input.GetButtonDown("Jump"))
        {
            jump = true;
        }
        if(Input.GetButtonDown("Fire1"))
        {
            shots = true;
        }
    }

    void FixedUpdate()
    {
        fiz.velocity = new Vector3(inputX*speed, fiz.velocity.y, inputZ*speed);
        if(jump==true)
        {
            Jumping();
            jump = false;
        }
        if(shots==true)
        {
            Shots();
            shots = false;
        }
    }

    void Jumping()
    {
        fiz.AddForce(0, 400, 0);
    }

    void Shots()
    {
        GameObject newbullet = Instantiate( bullet, bulletposition.position, Quaternion.identity);
        newbullet.GetComponent<Rigidbody>().velocity = new Vector3(0, 0, 20);
    } 
}
