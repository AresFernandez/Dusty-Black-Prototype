using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUp : MonoBehaviour
{

    public GameObject text;
    public GameObject ExitTrigger;

    private void OnTriggerStay(Collider other)
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            text.SetActive(true);
            Destroy(this.gameObject);
        }
    }
}
