using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUp : MonoBehaviour
{

    public GameObject text;
    public GameObject ExitTrigger;
    public GameObject PressEPanel;

    private void OnTriggerStay(Collider other)
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            PressEPanel.SetActive(false);
            text.SetActive(true);
            ExitTrigger.GetComponent<WinChecker>().missionDone = true;
            Destroy(this.gameObject);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            PressEPanel.SetActive(true);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            PressEPanel.SetActive(false);
        }
    }
}
