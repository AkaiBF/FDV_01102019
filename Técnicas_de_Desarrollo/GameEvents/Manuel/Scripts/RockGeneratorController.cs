using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RockGeneratorController : MonoBehaviour {

    public GameObject rockPrefab;
    public float generatorTimer = 1.75f;

	// Use this for initialization
	void Start () 
    {
        
	}
	
	// Update is called once per frame
	void Update () 
    {
		
	}

    void CreateRock()
    {
        Instantiate(rockPrefab, transform.position, Quaternion.identity);
    }

    public void StartGenerator()
    {
        InvokeRepeating("CreateRock", 0f, generatorTimer);
    }

    public void CancelGenerator(bool clean = false)
    {
        CancelInvoke("CreateRock");
        if (clean)
        {
            object[] allRocks = GameObject.FindGameObjectsWithTag("Rock");
            foreach (GameObject rock in allRocks)
            {
                Destroy(rock);
            }
        }
    }
}
