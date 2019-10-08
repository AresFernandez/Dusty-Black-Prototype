using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapSelector : MonoBehaviour
{
    public GameObject panel00, panel01, panel10, panel11;

    private Camera playerCam;


    // Start is called before the first frame update
    void Start()
    {
        playerCam = GameObject.Find("Main Camera").GetComponent<Camera>();
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Vector3 point = new Vector3(Input.mousePosition.x, Input.mousePosition.y, 0);
            Ray ray = playerCam.ScreenPointToRay(point);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit))
            {
                GameObject hitObject = hit.transform.parent.parent.gameObject;

                switch (hitObject.name)
                {
                    case "Slot 0 - 0":
                        panel00.SetActive(true);
                        panel01.SetActive(false);
                        panel10.SetActive(false);
                        panel11.SetActive(false);
                        break;
                    case "Slot 0 - 1":
                        panel00.SetActive(false);
                        panel01.SetActive(true);
                        panel10.SetActive(false);
                        panel11.SetActive(false);
                        break;
                    case "Slot 1 - 0":
                        panel00.SetActive(false);
                        panel01.SetActive(false);
                        panel10.SetActive(true);
                        panel11.SetActive(false);
                        break;
                    case "Slot 1 - 1":
                        panel00.SetActive(false);
                        panel01.SetActive(false);
                        panel10.SetActive(false);
                        panel11.SetActive(true);
                        break;
                    default:
                        panel00.SetActive(false);
                        panel01.SetActive(false);
                        panel10.SetActive(false);
                        panel11.SetActive(false);
                        break;
                }

            }
        }
    }
}
