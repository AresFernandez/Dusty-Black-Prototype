using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StrategySelector : MonoBehaviour
{
    public GameObject slot;
    public GameObject info;

    public Text title;
    public Text price1;
    public Text price2;
    public Text price3;
    public Text rate1;
    public Text rate2;
    public Text rate3;

    public Button button1;
    public Button button2;
    public Button button3;


    // Start is called before the first frame update
    void Start()
    {
        info = GameObject.Find("InfoHolder");
    }

    // Update is called once per frame
    void Update()
    {

        switch (slot.GetComponent<Base>().BaseType)
        {
            case Base.Type.PlayerBase1:
                title.text = "Allied Base Level 1";
                button1.gameObject.SetActive(false);
                price1.gameObject.SetActive(false);
                rate1.gameObject.SetActive(false);
                button2.gameObject.SetActive(false);
                price2.gameObject.SetActive(false);
                rate2.gameObject.SetActive(false);
                button3.gameObject.SetActive(false);
                price3.gameObject.SetActive(false);
                rate3.gameObject.SetActive(false);
                break;
            case Base.Type.PlayerBase2:
                title.text = "Allied Base Level 2";
                button1.gameObject.SetActive(false);
                price1.gameObject.SetActive(false);
                rate1.gameObject.SetActive(false);
                button2.gameObject.SetActive(false);
                price2.gameObject.SetActive(false);
                rate2.gameObject.SetActive(false);
                button3.gameObject.SetActive(false);
                price3.gameObject.SetActive(false);
                rate3.gameObject.SetActive(false);
                break;
            case Base.Type.PlayerBase3:
                title.text = "Allied Base Level 3";
                button1.gameObject.SetActive(false);
                price1.gameObject.SetActive(false);
                rate1.gameObject.SetActive(false);
                button2.gameObject.SetActive(false);
                price2.gameObject.SetActive(false);
                rate2.gameObject.SetActive(false);
                button3.gameObject.SetActive(false);
                price3.gameObject.SetActive(false);
                rate3.gameObject.SetActive(false);
                break;
            case Base.Type.EnemyBase1:
                title.text = "Enemy Base Level 1";
                price1.text = "Price: " + info.GetComponent<StrategyInfo>().littleBase.option1.price + "€";
                rate1.text = "Success Rate: " + info.GetComponent<StrategyInfo>().littleBase.option1.rate + "%";
                price2.text = "Price: " + info.GetComponent<StrategyInfo>().littleBase.option2.price + "€";
                rate2.text = "Success Rate: " + info.GetComponent<StrategyInfo>().littleBase.option2.rate + "%";
                price3.text = "Price: " + info.GetComponent<StrategyInfo>().littleBase.option3.price + "€";
                rate3.text = "Success Rate: " + info.GetComponent<StrategyInfo>().littleBase.option3.rate + "%";
                break;
            case Base.Type.EnemyBase2:
                title.text = "Enemy Base Level 2";
                price1.text = "Price: " + info.GetComponent<StrategyInfo>().mediumBase.option1.price + "€";
                rate1.text = "Success Rate: " + info.GetComponent<StrategyInfo>().mediumBase.option1.rate + "%";
                price2.text = "Price: " + info.GetComponent<StrategyInfo>().mediumBase.option2.price + "€";
                rate2.text = "Success Rate: " + info.GetComponent<StrategyInfo>().mediumBase.option2.rate + "%";
                price3.text = "Price: " + info.GetComponent<StrategyInfo>().mediumBase.option3.price + "€";
                rate3.text = "Success Rate: " + info.GetComponent<StrategyInfo>().mediumBase.option3.rate + "%";
                break;
            case Base.Type.EnemyBase3:
                title.text = "Enemy Base Level 3";
                price1.text = "Price: " + info.GetComponent<StrategyInfo>().largeBase.option1.price + "€";
                rate1.text = "Success Rate: " + info.GetComponent<StrategyInfo>().largeBase.option1.rate + "%";
                price2.text = "Price: " + info.GetComponent<StrategyInfo>().largeBase.option2.price + "€";
                rate2.text = "Success Rate: " + info.GetComponent<StrategyInfo>().largeBase.option2.rate + "%";
                price3.text = "Price: " + info.GetComponent<StrategyInfo>().largeBase.option3.price + "€";
                rate3.text = "Success Rate: " + info.GetComponent<StrategyInfo>().largeBase.option3.rate + "%";
                break;
            default:
                break;
        }



    }
}
