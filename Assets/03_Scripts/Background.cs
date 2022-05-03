using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Background : MonoBehaviour
{
    Material bgMat;
    public float speed=0.2f;
    void Start()
    {
        bgMat = GetComponent<MeshRenderer>().material;
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 direction = Vector2.up;

        bgMat.mainTextureOffset += direction * speed * Time.deltaTime;
    }
}
