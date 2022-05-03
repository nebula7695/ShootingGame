using UnityEngine;
using UnityEngine.SceneManagement;
public class Enemy : MonoBehaviour
{
    public GameObject explosionFactory;

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
        ScoreManager sm=GameObject.Find("ScoreManager").GetComponent<ScoreManager>();
        sm.SetScore(sm.GetScore()+1);            
        GameObject explosion=Instantiate(explosionFactory);
        explosion.transform.position = transform.position;

        if (collision.gameObject.CompareTag("Player"))
        {
            SceneManager.LoadScene("GameOver");
        }

        Destroy(gameObject);
        Destroy(collision.gameObject);
    }
}
