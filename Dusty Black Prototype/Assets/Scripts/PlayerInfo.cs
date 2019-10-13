using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerInfo : MonoBehaviour
{
    private int _health;
    public Animator anim;

    public Slider HPSlider;
    public GameObject DiePanel;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        _health = 100;
    }

    private void Update()
    {
        HPSlider.value = _health;
    }

    public void hurt(int damage)
    {
        _health -= damage;
        if (_health <= 0)
        {
            Player_movement behavior = GetComponent<Player_movement>();
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

        DiePanel.SetActive(true);
    }

}
