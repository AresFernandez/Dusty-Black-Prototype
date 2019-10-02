using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_shot : MonoBehaviour
{
    public float health = 100;

    public Animator anim;

    public void Start()
    {
        anim = GetComponent<Animator>();
    }


    public void GotShot()
    {

        health -= 40;
        if (health<=0)
        {
            Enemy_Movement behavior = GetComponent<Enemy_Movement>();
            if (behavior != null)
            {
                behavior.SetAlive(false);
            }
            StartCoroutine(Die());
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
