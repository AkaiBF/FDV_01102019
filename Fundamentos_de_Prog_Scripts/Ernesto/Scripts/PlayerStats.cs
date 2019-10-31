using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerStats : MonoBehaviour
{
    // Start is called before the first frame update

    public static int life;
    public static int thunderDmg;
    public static int fireDmg;
    public static int money;

    public Text lifeText;
    public Text moneyText;
    public Text fireText;
    public Text lightningText;

    void Start()
    {
        life = 100;
        thunderDmg = 0;
        fireDmg = 0;
        money = 0;
    }

    // Update is called once per frame
    void Update()
    {
        lifeText.text = "Life: " + life.ToString();
        moneyText.text = money.ToString() + "$";
        fireText.text = "Fire: " + fireDmg.ToString();
        lightningText.text = "Lightning: " + thunderDmg.ToString();
    }
}
