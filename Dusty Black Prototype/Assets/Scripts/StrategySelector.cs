using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StrategySelector : MonoBehaviour
{
    public GameObject slot;
    public GameObject info;
    public GameObject successPanel;
    public GameObject failPanel;

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

    public Text reward;

    private Color allyColor;
    private Color enemyColor;

    private bool selected;


    // Start is called before the first frame update
    void Start()
    {
        selected = false;
        info = GameObject.Find("InfoHolder");
        allyColor = new Color(103f/255f, 1, 103f/255f, 219f/255f);
        enemyColor = new Color(1, 53f/255f, 53f/255f, 219f/255f);
    }

    // Update is called once per frame
    void Update()
    {

        switch (slot.GetComponent<Base>().BaseType)
        {
            case Base.Type.PlayerBase1:
                this.gameObject.GetComponent<Image>().color = allyColor;
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
                reward.gameObject.SetActive(false);
                break;
            case Base.Type.PlayerBase2:
                this.gameObject.GetComponent<Image>().color = allyColor;
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
                reward.gameObject.SetActive(false);
                break;
            case Base.Type.PlayerBase3:
                this.gameObject.GetComponent<Image>().color = allyColor;
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
                reward.gameObject.SetActive(false);
                break;
            case Base.Type.EnemyBase1:
                this.gameObject.GetComponent<Image>().color = enemyColor;
                title.text = "Enemy Base Level 1";
                price1.text = "Price: " + info.GetComponent<StrategyInfo>().littleBase.option1.price + "€";
                rate1.text = "Success Rate: " + info.GetComponent<StrategyInfo>().littleBase.option1.rate + "%";
                price2.text = "Price: " + info.GetComponent<StrategyInfo>().littleBase.option2.price + "€";
                rate2.text = "Success Rate: " + info.GetComponent<StrategyInfo>().littleBase.option2.rate + "%";
                price3.text = "Price: " + info.GetComponent<StrategyInfo>().littleBase.option3.price + "€";
                rate3.text = "Success Rate: " + info.GetComponent<StrategyInfo>().littleBase.option3.rate + "%";
                reward.text = "Rewards   -   Win: " + info.GetComponent<StrategyInfo>().easyEnemy.strong.reward + "€   /   Lose: " + info.GetComponent<StrategyInfo>().easyEnemy.weak.reward + "€";
                break;
            case Base.Type.EnemyBase2:
                this.gameObject.GetComponent<Image>().color = enemyColor;
                title.text = "Enemy Base Level 2";
                price1.text = "Price: " + info.GetComponent<StrategyInfo>().mediumBase.option1.price + "€";
                rate1.text = "Success Rate: " + info.GetComponent<StrategyInfo>().mediumBase.option1.rate + "%";
                price2.text = "Price: " + info.GetComponent<StrategyInfo>().mediumBase.option2.price + "€";
                rate2.text = "Success Rate: " + info.GetComponent<StrategyInfo>().mediumBase.option2.rate + "%";
                price3.text = "Price: " + info.GetComponent<StrategyInfo>().mediumBase.option3.price + "€";
                rate3.text = "Success Rate: " + info.GetComponent<StrategyInfo>().mediumBase.option3.rate + "%";
                reward.text = "Rewards   -   Win: " + info.GetComponent<StrategyInfo>().mediumEnemy.strong.reward + "€   /   Lose: " + info.GetComponent<StrategyInfo>().mediumEnemy.weak.reward + "€";
                break;
            case Base.Type.EnemyBase3:
                this.gameObject.GetComponent<Image>().color = enemyColor;
                title.text = "Enemy Base Level 3";
                price1.text = "Price: " + info.GetComponent<StrategyInfo>().largeBase.option1.price + "€";
                rate1.text = "Success Rate: " + info.GetComponent<StrategyInfo>().largeBase.option1.rate + "%";
                price2.text = "Price: " + info.GetComponent<StrategyInfo>().largeBase.option2.price + "€";
                rate2.text = "Success Rate: " + info.GetComponent<StrategyInfo>().largeBase.option2.rate + "%";
                price3.text = "Price: " + info.GetComponent<StrategyInfo>().largeBase.option3.price + "€";
                rate3.text = "Success Rate: " + info.GetComponent<StrategyInfo>().largeBase.option3.rate + "%";
                reward.text = "Rewards   -   Win: " + info.GetComponent<StrategyInfo>().hardEnemy.strong.reward + "€   /   Lose: " + info.GetComponent<StrategyInfo>().hardEnemy.weak.reward + "€";
                break;
            default:
                break;
        }



    }

    public void Purchase(Base.Type type, int option)
    {
        if (!selected)
        {
            int price = 0, rate = 0;

            switch (slot.GetComponent<Base>().BaseType)
            {
                case Base.Type.PlayerBase1:
                    break;
                case Base.Type.PlayerBase2:
                    break;
                case Base.Type.PlayerBase3:
                    break;
                case Base.Type.EnemyBase1:
                    info.GetComponent<StrategyInfo>().difficulty = 1;
                    if (option == 1)
                    {
                        price = info.GetComponent<StrategyInfo>().littleBase.option1.price;
                        rate = info.GetComponent<StrategyInfo>().littleBase.option1.rate;
                    }
                    else if (option == 2)
                    {
                        price = info.GetComponent<StrategyInfo>().littleBase.option2.price;
                        rate = info.GetComponent<StrategyInfo>().littleBase.option2.rate;
                    } else if (option == 3)
                    {
                        price = info.GetComponent<StrategyInfo>().littleBase.option3.price;
                        rate = info.GetComponent<StrategyInfo>().littleBase.option3.rate;
                    }
                    break;
                case Base.Type.EnemyBase2:
                    info.GetComponent<StrategyInfo>().difficulty = 2;
                    if (option == 1)
                    {
                        price = info.GetComponent<StrategyInfo>().mediumBase.option1.price;
                        rate = info.GetComponent<StrategyInfo>().mediumBase.option1.rate;
                    }
                    else if (option == 2)
                    {
                        price = info.GetComponent<StrategyInfo>().mediumBase.option2.price;
                        rate = info.GetComponent<StrategyInfo>().mediumBase.option2.rate;
                    }
                    else if (option == 3)
                    {
                        price = info.GetComponent<StrategyInfo>().mediumBase.option3.price;
                        rate = info.GetComponent<StrategyInfo>().mediumBase.option3.rate;
                    }
                    break;
                case Base.Type.EnemyBase3:
                    info.GetComponent<StrategyInfo>().difficulty = 3;
                    if (option == 1)
                    {
                        price = info.GetComponent<StrategyInfo>().largeBase.option1.price;
                        rate = info.GetComponent<StrategyInfo>().largeBase.option1.rate;
                    }
                    else if (option == 2)
                    {
                        price = info.GetComponent<StrategyInfo>().largeBase.option2.price;
                        rate = info.GetComponent<StrategyInfo>().largeBase.option2.rate;
                    }
                    else if (option == 3)
                    {
                        price = info.GetComponent<StrategyInfo>().largeBase.option3.price;
                        rate = info.GetComponent<StrategyInfo>().largeBase.option3.rate;
                    }
                    break;
                default:
                    break;
            }

            info.GetComponent<StrategyInfo>().money -= price;

            int random = Random.Range(0, 100);

            if (random <= rate)
            {
                //Success Case
                info.GetComponent<StrategyInfo>().strategySuccess = true;
                successPanel.SetActive(true);
            }
            else
            {
                //Fail Case
                info.GetComponent<StrategyInfo>().strategySuccess = false;
                failPanel.SetActive(true);
            }

            info.GetComponent<StrategyInfo>().activeSlot = slot.name;

           selected = true;
        }
    }

}
