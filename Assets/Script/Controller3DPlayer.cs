using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller3DPlayer : MonoBehaviour
{
    public Animator animator;
    // Start is called before the first frame update
    public float forceExternal;
    public float forceRotation;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        var horizontal = Input.GetAxis("Horizontal");
        var vertical = Input.GetAxis("Vertical");
        MovePlayer(vertical, horizontal);
    }

    private void MovePlayer(float X, float Y)
    {
        if (X == 0 && Y == 0)
        {
            animator.Play("Grounded");
        } 
        else 
        {
            animator.Play("HumanoidWalk");
            Vector3 force = transform.forward * X * forceExternal * Time.deltaTime;
            GetComponent<Rigidbody>().velocity = force;
            //agregamos rotacion
            if (Y != 0)
            {
                transform.Rotate(0, Y * forceRotation * Time.deltaTime, 0);
                /*if (Y < 0 && X == 0)
                {
                    animator.Play("StandHalfTurnRight");
                }
                else if (Y > 0 && X == 0)
                {
                    animator.Play("StandHalfTurnLeft");
                }*/
                
            }
        }
    }
}
