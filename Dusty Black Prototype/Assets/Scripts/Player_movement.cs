using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_movement : MonoBehaviour
{
    public float speed = 6.0f;
    public float gravity = -9.8f;

    private bool _alive;
    private CharacterController _charCont;

    private Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        _alive = true;
        _charCont = GetComponent<CharacterController>();
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (_alive)
        {
            float deltaX = Input.GetAxis("Horizontal") * speed;
            float deltaZ = Input.GetAxis("Vertical") * speed;
            Vector3 movement = new Vector3(deltaX, 0, deltaZ);
            movement = Vector3.ClampMagnitude(movement, speed);

            movement.y = gravity;

            movement *= Time.deltaTime;
            movement = transform.TransformDirection(movement);
            _charCont.Move(movement);


            //Animation forward
            if (deltaZ > 0) { animator.SetBool("IsGoingForward", true); }
            else { animator.SetBool("IsGoingForward", false); }

            //Animation backward
            if (deltaZ < 0 && !(deltaZ > 0)) { animator.SetBool("IsGoingBack", true); }
            else { animator.SetBool("IsGoingBack", false); }

            //Animation right
            if (deltaX > 0 && deltaZ == 0) { animator.SetBool("IsGoingRight", true); }
            else { animator.SetBool("IsGoingRight", false); }

            //Animation left
            if (deltaX < 0 && deltaZ == 0 && !(deltaX > 0)) { animator.SetBool("IsGoingLeft", true); }
            else { animator.SetBool("IsGoingLeft", false); }

        }


    }

    public void SetAlive(bool alive)
    {
        _alive = alive;
    }
}
