using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Movement : MonoBehaviour
{

    public float speed = 3.0f;
    public float obstacleRange = 5.0f;

    private bool _alive, move;
    public float timeStart, shotInterval = 2;

    public GameObject paintballPrefab;
    private GameObject player;
    private Animator animator;





    // Start is called before the first frame update
    void Start()
    {
        _alive = move = true;
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (_alive && move)
        {
            transform.Translate(0, 0, speed * Time.deltaTime);
            Ray ray = new Ray(transform.position, transform.forward);
            RaycastHit hit;
            if (Physics.SphereCast(ray, 0.75f, out hit))
            {
                if (hit.distance < obstacleRange)
                {
                    float angle = 180;
                    transform.Rotate(0, angle, 0);
                }
            }
        }
        else if (_alive && !move)
        {
            transform.LookAt(player.transform);
            if (Time.time - timeStart >= shotInterval)
            {
                animator.SetTrigger("IsShooting");
                Instantiate(paintballPrefab, transform.TransformPoint(Vector3.forward * 1.5f + Vector3.up), transform.rotation);
                timeStart = Time.time;
            }
        }

    }


    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            move = false;
            animator.SetBool("IsAim", true);
            timeStart = Time.time;
            player = other.gameObject;
        }
    }



    public void SetAlive(bool alive)
    {
        _alive = alive;
    }
}
