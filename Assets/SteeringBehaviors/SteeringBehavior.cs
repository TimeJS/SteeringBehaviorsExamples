using UnityEngine;
using System.Collections;

	

public interface SteeringBehavior 
{
    public Vector3 CalculateSteeringForce(float maxVelocity);
}