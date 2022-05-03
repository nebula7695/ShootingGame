using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public float speed=5;  
   
    void Update()
    {
        //->.d : 1. <-,a : -1, 0 
        float h = Input.GetAxis("Horizontal");
        //-1,0,1
        float v = Input.GetAxis("Vertical");
       // Debug.Log("h: " + h + " v: " +v);
        Vector3 dir = new Vector3(h, v, 0);
        dir = (dir.magnitude > 1) ? dir.normalized : dir;
        transform.Translate(dir * speed * Time.deltaTime);
    }
  
}
