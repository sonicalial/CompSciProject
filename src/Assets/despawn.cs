using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class despawn : MonoBehaviour
{
    public Rigidbody rb;
    public static int timer = 0;
    // Start is called before the first frame update
    void Start()
    {
        timer = 120;
        Vector3 pos = Camera.main.WorldToScreenPoint(transform.position);
        Vector3 dir = Input.mousePosition - pos;
        rb.AddForce(dir * 2);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        timer = timer - 1;
        if (timer == 0)
        {
            DestroyImmediate(this.gameObject);
            Debug.Log("bullet destroyed");
            timer = 120;
        }
    }
}
