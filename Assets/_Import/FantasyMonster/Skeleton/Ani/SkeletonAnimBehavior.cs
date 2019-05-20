using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkeletonAnimBehavior : MonoBehaviour
{
    private Animator animator;
    private SteeringCrowdUnit unit;
    private float speed;

    void Start()
    {
        animator = GetComponentInChildren<Animator>();
        unit = GetComponent<SteeringCrowdUnit>();
    }
    void Update()
    {
        Vector3 velocity = unit.Velocity;
        speed = velocity.magnitude;
        AnimatorStateInfo stateInfo = animator.GetCurrentAnimatorStateInfo(0);
        //if (Input.GetKeyDown(KeyCode.A))
        //{
            
        //}
        animator.SetFloat("speed", speed);
    }
}
