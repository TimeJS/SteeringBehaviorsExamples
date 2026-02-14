using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SteeringObject : MonoBehaviour
{
    public float maxForce = 1.0f;
    public float maxVelocity = 3.0f;

    public SteeringBehavior[] steeringBehaviors;
        
    // Start is called before the first frame update
    void Start()
    {
        //nop
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        steeringBehaviors = GetComponents<SteeringBehavior>();
        Vector3 steeringForce = new Vector3(0, 0, 0);
        foreach (SteeringBehavior steeringBehavior in steeringBehaviors)
        {
            if (steeringBehavior != null && steeringBehavior.enabled)
            {
                steeringForce = steeringForce + steeringBehavior.CalculateSteeringForce(maxVelocity);
            }
        }
        GetComponent<Rigidbody>().AddForce(steeringForce);
    }

    public void AddSteeringBehavior(SteeringBehavior sb)
    {
        // Deprecated, no-op or just add to list (which is overwritten in FixedUpdate anyway)
    }

    public void RemoveSteeringBehavior(SteeringBehavior sb)
    {
        // Deprecated
    }

}