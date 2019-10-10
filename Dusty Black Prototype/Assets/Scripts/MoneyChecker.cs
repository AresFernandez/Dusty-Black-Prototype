using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MoneyChecker : MonoBehaviour
{
    public Text moneyText;
    public GameObject infoHolder;

    // Start is called before the first frame update
    void Start()
    {
        infoHolder = GameObject.Find("InfoHolder");
    }

    // Update is called once per frame
    void Update()
    {
        moneyText.text = "Money: " + infoHolder.GetComponent<StrategyInfo>().money + "€";


    }
}
