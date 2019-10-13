using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Base : MonoBehaviour
{
    public GameObject PlayerBase1, PlayerBase2, PlayerBase3, EnemyBase1, EnemyBase2, EnemyBase3;

    public enum Type  { PlayerBase1, PlayerBase2, PlayerBase3, EnemyBase1, EnemyBase2, EnemyBase3 }

    public Type BaseType;

    public GameObject adjacent1, adjacent2;

    // Start is called before the first frame update
    void Start()
    {
        StrategyInfo info = GameObject.Find("InfoHolder").GetComponent<StrategyInfo>();

        if (this.gameObject.name == "Slot 0 - 0")
        {
            BaseType = info.slot00;
        }
        else if (this.gameObject.name == "Slot 0 - 1")
        {
            BaseType = info.slot01;
        }
        else if (this.gameObject.name == "Slot 1 - 0")
        {
            BaseType = info.slot10;
        }
        else if (this.gameObject.name == "Slot ¡1 - 1")
        {
            BaseType = info.slot11;
        }


        switch (BaseType)
        {
            case Type.PlayerBase1:
                Instantiate<GameObject>(PlayerBase1, this.transform);
                break;
            case Type.PlayerBase2:
                Instantiate<GameObject>(PlayerBase2, this.transform);
                break;
            case Type.PlayerBase3:
                Instantiate<GameObject>(PlayerBase3, this.transform);
                break;
            case Type.EnemyBase1:
                Instantiate<GameObject>(EnemyBase1, this.transform);
                break;
            case Type.EnemyBase2:
                Instantiate<GameObject>(EnemyBase2, this.transform);
                break;
            case Type.EnemyBase3:
                Instantiate<GameObject>(EnemyBase3, this.transform);
                break;
            default:
                break;  
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
