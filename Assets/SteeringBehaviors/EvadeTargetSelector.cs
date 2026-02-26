using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EvadeTargetSelector : MonoBehaviour
{
    public string targetTag = "Target";
    public float checkInterval = 0.5f;

    private Evade evadeBehavior;

    void Start()
    {
        evadeBehavior = GetComponent<Evade>();
        InvokeRepeating(nameof(UpdateTarget), 0f, checkInterval);
    }

    void UpdateTarget()
    {
        Rigidbody[] bodies = FindObjectsOfType<Rigidbody>();

        GameObject closest = null;
        float closestDistance = Mathf.Infinity;

        foreach (Rigidbody body in bodies)
        {
            if (body.gameObject == gameObject) continue;

            float distance = Vector3.Distance(transform.position, body.transform.position);

            if (distance < closestDistance)
            {
                closestDistance = distance;
                closest = body.gameObject;
            }
        }

        if (closest != null)
        {
            evadeBehavior.target = closest;
        }
    }
}