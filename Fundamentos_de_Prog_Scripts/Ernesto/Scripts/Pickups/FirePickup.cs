using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirePickup : MonoBehaviour
{
    public GameObject usedFire;
    private GameObject player;
    private bool active = true;

    // Start is called before the first frame update
    void Start()
    {
        this.player = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        if (this.active && Vector3.Distance(this.transform.position, player.transform.position) < GameController.maxDistance)
        {
            PlayerStats.fireDmg += 10;
            this.transform.GetChild(2).GetComponent<MeshRenderer>().material = usedFire.transform.GetChild(2).GetComponent<MeshRenderer>().sharedMaterial;
            this.active = false;
        }
    }
}
