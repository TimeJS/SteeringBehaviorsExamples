using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickAvoider : MonoBehaviour
{
    // Start is called before the first frame update
    private Seeker seeker;
    private ObstacleAvoider avoider;
    public float breakingForce = 0;
    void Start()
    {
        Rigidbody rb = GetComponent<Rigidbody>();
        SteeringObject so = GetComponent<SteeringObject>();
        seeker = gameObject.AddComponent<Seeker>();
        seeker.rb = rb;
        
        avoider = gameObject.AddComponent<ObstacleAvoider>();
        avoider.gameObj = gameObject;
        avoider.rb = rb;
        avoider.objXform = transform;
        avoider.renderer = GetComponent<Renderer>();
        
        so.AddSteeringBehavior(seeker);
        so.AddSteeringBehavior(avoider);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            Debug.Log("GOT CLICK");
            Ray ray = Camera.main.ScreenPointToRay(
                Input.mousePosition);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit))
            {
                seeker.SetSeekPosition(hit.point);
            }
        }
        
    }
}
