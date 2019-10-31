using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoneyPickup : MonoBehaviour
{
    public GameObject usedMoney;
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
            PlayerStats.money += 10;
            this.transform.GetChild(0).GetComponent<MeshRenderer>().material = usedMoney.transform.GetChild(0).GetComponent<MeshRenderer>().sharedMaterial;
            this.active = false;
        }
    }
}
