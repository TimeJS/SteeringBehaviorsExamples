using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class GroupBehavior : SteeringBehavior
{
    
    public GameObject _gameObject;

    public void Awake()
    {
        _gameObject = gameObject;
    }

    public SteeringObject[] FindSteeringObjects()
    {
        List<GameObject> gameObjects = new List<GameObject>();
        SteeringObject[] steeringObjects = Object.FindObjectsOfType<SteeringObject>();
        return steeringObjects;
    }


    internal List<GameObject> GroupFindNeighors(float radius)
    {
        List<GameObject> neighbors = new List<GameObject>();
        SteeringObject[] steeringObjects = FindSteeringObjects();
        Rigidbody myRB = _gameObject.GetComponent<Rigidbody>();
        // easier to calculate then sqrt and has the virtue of always being positive
        float sqRadius = radius*radius;
        
        foreach (var steeringObject in steeringObjects)
        {
            GameObject otherGO = steeringObject.gameObject;
            Rigidbody otherRigidbody = otherGO.GetComponent<Rigidbody>();
            if ((otherRigidbody != null)&&(otherRigidbody!=myRB))
            {
                if ((otherRigidbody.position - myRB.position).sqrMagnitude >= sqRadius)
                {
                    neighbors.Add(otherGO);
                }
            }
        }

        return neighbors;
    }

    public abstract override Vector3 CalculateSteeringForce(float maxVelocity);

}