using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading;

public class movement : MonoBehaviour
{
    public static int speed = 15;
    public static int timer = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void OnTriggerEnter2D()
    {
        timer = 5;
        speed = speed *-1;
    }

    // Update is called once per frame
    void  FixedUpdate()
    {
        if (timer != 0)
        {
            timer--;
        }
        else
        {
            speed = 15;
        }
            
        if (Input.GetKey("w") && Input.GetKey("d"))  
        {
           transform.Translate(Vector3.up * speed * Time.deltaTime);
           transform.Translate(Vector3.right * speed * Time.deltaTime);
        }
        else if (Input.GetKey("w") && Input.GetKey("a"))
        {
           transform.Translate(Vector3.up * speed * Time.deltaTime);
           transform.Translate(Vector3.left * speed * Time.deltaTime);
        }
        else if (Input.GetKey("s") && Input.GetKey("a"))
        {
           transform.Translate(Vector3.down * speed * Time.deltaTime);
           transform.Translate(Vector3.left * speed * Time.deltaTime);
        }
        else if (Input.GetKey("s") && Input.GetKey("d"))
        {
           transform.Translate(Vector3.down * speed * Time.deltaTime);
           transform.Translate(Vector3.right * speed * Time.deltaTime);
        }
        else if (Input.GetKey("w"))
        {
           transform.Translate(Vector3.up * speed * Time.deltaTime);
        }
        else if (Input.GetKey("s"))
        {
           transform.Translate(Vector3.down * speed * Time.deltaTime);
        }
        else if (Input.GetKey("a"))
        {
          transform.Translate(Vector3.left * speed * Time.deltaTime);
        }
        else if (Input.GetKey("d"))
        {
           transform.Translate(Vector3.right * speed * Time.deltaTime);
        }


        
    }
}
