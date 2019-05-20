using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowerManager : MonoBehaviour
{
    //Follower Spawn Attributes
    public GameObject[] units;
    public GameObject unitPrefab;
    public int numUnits = 10;
    public float range = 20f;


    //Follower Behaviour Attributes
    //[Range(0, 20)]
    //public float leaderBehindDistance = 5f;
    //[Range(0, 20)]
    //public float neighbourRadius = 3f;
    //[Range(0, 20)]
    //public float followerMaxSeparation = 5f;

    // Start is called before the first frame update
    void Start()
    {
        units = new GameObject[numUnits];
        for (int i = 0; i < numUnits; i++)
        {
            Vector3 unitPos = new Vector3(Random.Range(-range, range), 0.6f, Random.Range(-range, range));
            units[i] = Instantiate(unitPrefab, this.transform.position + unitPos, Quaternion.identity) as GameObject;
        }
    }




    // Update is called once per frame
    void Update()
    {
        
    }
}
