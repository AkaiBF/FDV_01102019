using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public GameObject[] backgrounds;
    public GameObject[] pull;
    public List<GameObject> pool;
    public float scrollSpeed = 2.0f;
    // Start is called before the first frame update
    void Start()
    {
        pool = new List<GameObject>(pull);
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.UpArrow))
          foreach(GameObject i in backgrounds)
            i.transform.Translate(Vector2.down * scrollSpeed * Time.deltaTime);
        // if (condición de parada) Time.timescale = 0;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Asteroid"))
        {
            collision.gameObject.GetComponent<Rigidbody2D>().velocity = Vector2.zero;
            collision.gameObject.GetComponent<Transform>().position = new Vector2(23f, -3f);
            pool.Add(collision.gameObject);
        } else {
            collision.GetComponent<Transform>().position = new Vector2(collision.GetComponent<Transform>().position.x, collision.GetComponent<Transform>().position.y + (11.52f * backgrounds.Length));
            int rnd = Random.Range(1, 5);
            for (int i = 0; i < rnd; i++)
            {
                if (pool.Count > 0)
                {
                    int rpll = Random.Range(0, pool.Count);
                    GameObject asteroide = pool[rpll];
                    pool.Remove(asteroide);
                    asteroide.GetComponent<Transform>().position = new Vector2(-7.2f + Random.Range(0f, 7.2f), collision.GetComponent<Transform>().position.y + (11.52f * backgrounds.Length) - 5.76f + Random.Range(0f, 17.28f));
                    asteroide.GetComponent<Rigidbody2D>().AddForce(Vector2.down * scrollSpeed * Random.Range(40f, 150f));
                }
            }
        }
    }
}
