using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShot : MonoBehaviour
{
    public float speed = 10.0f;
    public int damage = 20;

    private StrategyInfo infoHolder;

    // Start is called before the first frame update
    void Start()
    {
        infoHolder = GameObject.Find("InfoHolder").GetComponent<StrategyInfo>();

        if (infoHolder.difficulty == 1)
        {
            if (infoHolder.strategySuccess)
            {
                speed = infoHolder.easyEnemy.weak.speed;
                damage = infoHolder.easyEnemy.weak.damage;
            }
            else
            {
                speed = infoHolder.easyEnemy.strong.speed;
                damage = infoHolder.easyEnemy.strong.damage;
            }
        }
        else if (infoHolder.difficulty == 2)
        {
            if (infoHolder.strategySuccess)
            {
                speed = infoHolder.mediumEnemy.weak.speed;
                damage = infoHolder.mediumEnemy.weak.damage;
            }
            else
            {
                speed = infoHolder.mediumEnemy.strong.speed;
                damage = infoHolder.mediumEnemy.strong.damage;
            }
        }
        else if (infoHolder.difficulty == 3)
        {
            if (infoHolder.strategySuccess)
            {
                speed = infoHolder.hardEnemy.weak.speed;
                damage = infoHolder.hardEnemy.weak.damage;
            }
            else
            {
                speed = infoHolder.hardEnemy.strong.speed;
                damage = infoHolder.hardEnemy.strong.damage;
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0, 0, speed * Time.deltaTime);
    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            PlayerInfo player = other.GetComponent<PlayerInfo>();
            if (player != null)
            {
                player.hurt(damage);
            }
            Destroy(this.gameObject);
        }
        else
        {
            if (!other.CompareTag("Enemy"))
            {
                Destroy(this.gameObject);
            }
        }

    }

}
