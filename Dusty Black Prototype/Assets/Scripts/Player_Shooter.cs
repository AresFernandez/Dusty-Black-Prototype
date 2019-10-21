using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Shooter : MonoBehaviour
{

    public GameObject bloodParticles;
    public GameObject dustParticles;
    public GameObject shotParticles;
    public Transform canonPos;
    public Transform rifle;
    private Camera playerCam;
    private Animator animator;
    private float timeStart, shotInterval = 0.5f;

    // Start is called before the first frame update
    void Awake()
    {
        timeStart = Time.time;
        playerCam = GetComponent<Camera>();
        animator = GetComponentInParent<Animator>();
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
        animator.SetBool("IsAim",true);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0) && (Time.time - timeStart >= shotInterval))
        {
            timeStart = Time.time;
            animator.SetTrigger("IsShooting");
            Instantiate<GameObject>(shotParticles, canonPos.position, canonPos.rotation,rifle);
            Vector3 point = new Vector3(playerCam.pixelWidth / 2, playerCam.pixelHeight / 2, 0);
            Ray ray = playerCam.ScreenPointToRay(point);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit))
            {
                GameObject hitObject = hit.transform.gameObject;

                Enemy_shot target = hitObject.GetComponent<Enemy_shot>();

                if (target != null)
                {
                    target.GotShot();
                    Instantiate<GameObject>(bloodParticles, hit.point, new Quaternion());
                }
                else
                {
                    ShotGen(hit.point);
                }
                
            }
        }
    }


    private void ShotGen (Vector3 pos)
    {
        Instantiate<GameObject>(dustParticles, pos, new Quaternion());
        ////generar explosion particulas
        //GameObject sphere = GameObject.CreatePrimitive(PrimitiveType.Sphere);
        //sphere.transform.localScale = new Vector3(0.2f, 0.2f, 0.2f);
        //sphere.transform.position = pos;

        //yield return new WaitForSeconds(1);

        //Destroy(sphere);
    }

    private void OnGUI()
    {
        int size = 12;
        float posX = playerCam.pixelWidth / 2 - size / 4;
        float posY = playerCam.pixelHeight / 2 - size / 2;
        GUI.Label(new Rect(posX, posY, size, size), "+");
    }

}
