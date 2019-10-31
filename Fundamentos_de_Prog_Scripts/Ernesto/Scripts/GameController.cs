using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    public float timeLapse = 60.0f;
    private float currentTime = 0.0f;
    private int maxLength = 1000;
    private int maxWidth = 1000;
    public GameObject health;
    public GameObject sparks;
    public GameObject fire;
    public GameObject money;

    public Text timeText;
    public static float maxDistance = 5.0f;

    public int numElements;

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < numElements; i++)
        {
            Instantiate(this.health, new Vector3(Random.Range(0, maxLength), -4, Random.Range(0, maxWidth)), Quaternion.identity);
            Instantiate(this.sparks, new Vector3(Random.Range(0, maxLength), -4, Random.Range(0, maxWidth)), Quaternion.identity);
            Instantiate(this.fire, new Vector3(Random.Range(0, maxLength), -4, Random.Range(0, maxWidth)), Quaternion.identity);
            Instantiate(this.money, new Vector3(Random.Range(0, maxLength), -4, Random.Range(0, maxWidth)), Quaternion.identity);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if(Time.deltaTime * this.currentTime < timeLapse)
        {
            this.currentTime += 1.0f;
        } else
        {
            foreach(GameObject objeto in GameObject.FindGameObjectsWithTag("pickups")) {
                objeto.transform.position = new Vector3(Random.Range(0, maxLength), -4, Random.Range(0, maxWidth));
                this.currentTime = 0.0f;
            }
        }
        this.timeText.text = (60 - (Time.deltaTime * currentTime)).ToString();
    }
}
