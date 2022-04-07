using UnityEngine;

public class Enemy : MonoBehaviour
{
    float speed = 5;
    Vector3 dir;
    private void Start()
    {
        int rd = Random.Range(0, 10);//0~9
        if (rd<3)
        {
            GameObject target = GameObject.Find("Player");
            dir = target.transform.position - transform.position;
            //dir = (dir.magnitude!=1)? dir.normalized:dir;
            dir.Normalize();

        }
        else
        {
            dir = Vector3.down;
        }
    }
    void Update()
    {
        transform.Translate(dir * speed * Time.deltaTime);
    }
    private void OnCollisionEnter(Collision collision)
    {
        Destroy(gameObject);
        Destroy(collision.gameObject);
    }
}
