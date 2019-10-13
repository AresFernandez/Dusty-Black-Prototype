using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class DiePanel : MonoBehaviour
{

    public GameObject infoHolder;
    public float DieTime = 3;

    private float startTime;

    // Start is called before the first frame update
    void Start()
    {
        infoHolder = GameObject.Find("InfoHolder");
        startTime = Time.time;
        infoHolder.GetComponent<StrategyInfo>().MissionFail();
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time - startTime >= DieTime)
        {

            SceneManager.LoadScene("StrategyScene");
        }
    }
}
