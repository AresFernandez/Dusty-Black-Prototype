using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_shot : MonoBehaviour
{
    public float health = 100;

    private StrategyInfo infoHolder;

    public Animator anim;

    public void Start()
    {
        anim = GetComponent<Animator>();

        infoHolder = GameObject.Find("InfoHolder").GetComponent<StrategyInfo>();

        if (infoHolder.difficulty == 1)
        {
            if (infoHolder.strategySuccess)
            {
                health = infoHolder.easyEnemy.weak.health;
            }
            else
            {
                health = infoHolder.easyEnemy.strong.health;
            }
        }
        else if (infoHolder.difficulty == 2)
        {
            if (infoHolder.strategySuccess)
            {
                health = infoHolder.mediumEnemy.weak.health;
            }
            else
            {
                health = infoHolder.mediumEnemy.strong.health;
            }
        }
        else if (infoHolder.difficulty == 3)
        {
            if (infoHolder.strategySuccess)
            {
                health = infoHolder.hardEnemy.weak.health;
            }
            else
            {
                health = infoHolder.hardEnemy.strong.health;
            }
        }
    }


    public void GotShot()
    {
        Enemy_Movement behavior = GetComponent<Enemy_Movement>();
        health -= 40;
        if (health<=0)
        {
            if (behavior != null)
            {
                behavior.SetAlive(false);
            }
            StartCoroutine(Die());
        }
        if (behavior != null)
        {
            behavior.EnemyAware();
        }
    }

    private IEnumerator Die()
    {
        //this.transform.Rotate(-75, 0, 0);
        anim.SetTrigger("IsDead");


        yield return new WaitForSeconds(1f);

        Destroy(this.gameObject);
    }



}
