using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StrategyInfo : MonoBehaviour
{
    //Singleton reference
    private static StrategyInfo _instance = null;

    //Strategy stuff
    public int money;

    public struct OptionInfo
    {
        public int price;
        public int rate;
    };

    public struct BaseOptions
    {
        public OptionInfo option1;
        public OptionInfo option2;
        public OptionInfo option3;
    };

    public BaseOptions littleBase;
    public BaseOptions mediumBase;
    public BaseOptions largeBase;


    //Singleton behavior
    public static StrategyInfo Instance {
        get
        {
            if (_instance == null)
            {
                _instance = GameObject.FindObjectOfType<StrategyInfo>();
            }

            return _instance;
        }
    }

    private void Awake()
    {
        DontDestroyOnLoad(gameObject);
    }




    // Start is called before the first frame update
    void Start()
    {
        money = 500;

        //Little base
        littleBase.option1.price = 25;
        littleBase.option1.rate = 45;

        littleBase.option2.price = 50;
        littleBase.option2.rate = 70;

        littleBase.option3.price = 100;
        littleBase.option3.rate = 85;

        //Medium base
        mediumBase.option1.price = 35;
        mediumBase.option1.rate = 30;

        mediumBase.option2.price = 60;
        mediumBase.option2.rate = 60;

        mediumBase.option3.price = 120;
        mediumBase.option3.rate = 75;

        //Large base
        largeBase.option1.price = 50;
        largeBase.option1.rate = 10;

        largeBase.option2.price = 80;
        largeBase.option2.rate = 30;

        largeBase.option3.price = 200;
        largeBase.option3.rate = 60;

    }

    // Update is called once per frame
    void Update()
    {
        
    }

}
