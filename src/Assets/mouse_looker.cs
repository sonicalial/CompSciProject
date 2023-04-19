using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mouse_looker : MonoBehaviour
{
    public GameObject bullet;
    public static int timer = 0;
    void FixedUpdate()
    {
        timer = timer-1;
        Vector3 pos = Camera.main.WorldToScreenPoint(transform.position);
        Vector3 dir = Input.mousePosition - pos;
        Vector3 playerPos = GameObject.FindGameObjectsWithTag("Player")[0].transform.position;
        transform.position = playerPos;
        transform.position = Vector3.MoveTowards(GameObject.Find("Player").transform.position,dir,1);
        float angle = Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);
        if (Input.GetMouseButton(0))
        {
            if (timer <= 0)
            {
                Instantiate(bullet, transform.position, Quaternion.identity);
                timer = 5;
            }
        }
    }
}
