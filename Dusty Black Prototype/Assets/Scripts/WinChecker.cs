using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinChecker : MonoBehaviour
{
    public bool missionDone;
    public GameObject winPanel;

    // Start is called before the first frame update
    void Start()
    {
        missionDone = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player" && missionDone)
        {
            winPanel.SetActive(true);
        }
    }
}
