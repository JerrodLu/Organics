using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class button : MonoBehaviour
{
    public float money = 0;
    public Text moneyText;
    public GameObject canvas;

    void Start()
    {
        DisplayMoney();
    }

    void Update()
    {
        DisplayMoney();
    }

    public void FishQuartMoney()
    {
        money += 5;
        Debug.Log(money);
    }

    public void DisplayMoney()
    {
        moneyText.text = "$ " + money;
    }

}
