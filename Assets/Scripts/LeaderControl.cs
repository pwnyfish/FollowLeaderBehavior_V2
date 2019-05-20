using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeaderControl : MonoBehaviour
{
    //Leader Attributes
    private Vector3 targetPosition;
    Vector3 lookAtTarget;
    Quaternion leaderRot;
    [Range(0, 20)]
    public float speed = 10f;
    [Range(0, 20)]
    public float rotSpeed = 10f;
    public bool moving = false;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetMouseButton(0))
        {
            SetTargetPosition();
        }
        if (moving)
        {
            Move();
        }
    }

    public void SetTargetPosition()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit rayHit;

        if (Physics.Raycast(ray, out rayHit, Mathf.Infinity))
        {
            targetPosition = new Vector3(rayHit.point.x,rayHit.point.y+0.5f,rayHit.point.z);
            lookAtTarget = new Vector3(targetPosition.x - transform.position.x, transform.position.y, targetPosition.z - transform.position.z);
            leaderRot = Quaternion.LookRotation(lookAtTarget);
            moving = true;
        }
    }

    void Move()
    {
        transform.rotation = Quaternion.Slerp(transform.rotation, leaderRot, rotSpeed * Time.deltaTime);
        transform.position = Vector3.MoveTowards(transform.position, targetPosition, speed * Time.deltaTime);
        if (Vector3.Distance(transform.position, targetPosition) < 0.001f)
        {
            moving = false;
        }
    }
}
