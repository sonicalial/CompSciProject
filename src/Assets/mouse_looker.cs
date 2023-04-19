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
        Vector3 pos = Camera.main.WorldToScreenPoint(transform.position);//gets mouse position
        Vector3 dir = Input.mousePosition - pos;
        Vector3 playerPos = GameObject.FindGameObjectsWithTag("Player")[0].transform.position;//gets the player location
        transform.position = playerPos;//teleports the rectangle (gun) onto the player
        transform.position = Vector3.MoveTowards(GameObject.Find("Player").transform.position,dir,1); //displaces the gun so that it points out one end not both
        float angle = Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg;//tbh i dont know. it is important. stiched this together from many other sorces
        transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);//rotates the gun so it points toward the mouse using strange maths on line 17
        
        if (Input.GetMouseButton(0)) 
        {
            if (timer <= 0)
            {
                Instantiate(bullet, transform.position, Quaternion.identity); //this "if" spawns a bullet when mouse is clicked and the cool down timer is down 
                timer = 5;// cool down timer to prevent way to many bullets 
            }
        }
    }
}
