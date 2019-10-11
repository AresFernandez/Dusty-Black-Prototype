using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StrategyInfo : MonoBehaviour
{
    //Singleton reference
    private static StrategyInfo _instance = null;

    //Strategy stuff
    public int money;

    public int difficulty;
    public bool strategySuccess;

    public string activeSlot;
    
    public GameObject slot00, slot01, slot10, slot11;

    public struct EnemyShotStats
    {
        public float speed;
        public int damage;
    }

    public struct EnemyType
    {
        public EnemyShotStats weak;
        public EnemyShotStats strong;
    }

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

    public EnemyType easyEnemy;
    public EnemyType mediumEnemy;
    public EnemyType hardEnemy;


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
        //global stats
        money = 500;

        //Enemy Stats
        easyEnemy.weak.speed = 10.0f;
        easyEnemy.strong.speed = 10.0f;

        mediumEnemy.weak.speed = 15.0f;
        mediumEnemy.strong.speed = 15.0f;

        hardEnemy.weak.speed = 20.0f;
        hardEnemy.strong.speed = 20.0f;

        easyEnemy.weak.damage = 20;
        easyEnemy.strong.damage = 25;

        mediumEnemy.weak.damage = 40;
        mediumEnemy.strong.damage = 60;

        hardEnemy.weak.damage = 70;
        hardEnemy.strong.damage = 100;

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


        // Slots management
        slot00.GetComponent<Base>().BaseType = Base.Type.PlayerBase3;
        slot01.GetComponent<Base>().BaseType = Base.Type.EnemyBase1;
        slot10.GetComponent<Base>().BaseType = Base.Type.EnemyBase2;
        slot11.GetComponent<Base>().BaseType = Base.Type.EnemyBase3;

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void MissionSuccess()
    {
        if (activeSlot == "Slot 0 - 0")
        {
            switch (slot00.GetComponent<Base>().BaseType)
            {
                case Base.Type.PlayerBase1:
                    slot00.GetComponent<Base>().BaseType = Base.Type.PlayerBase2;
                    break;
                case Base.Type.PlayerBase2:
                    slot00.GetComponent<Base>().BaseType = Base.Type.PlayerBase3;
                    break;
                case Base.Type.PlayerBase3:
                    break;
                case Base.Type.EnemyBase1:
                    slot00.GetComponent<Base>().BaseType = Base.Type.PlayerBase1;
                    break;
                case Base.Type.EnemyBase2:
                    slot00.GetComponent<Base>().BaseType = Base.Type.EnemyBase1;
                    break;
                case Base.Type.EnemyBase3:
                    slot00.GetComponent<Base>().BaseType = Base.Type.EnemyBase2;
                    break;
                default:
                    break;
            }
        }
    }

    void MissionFail()
    {

    }

}
