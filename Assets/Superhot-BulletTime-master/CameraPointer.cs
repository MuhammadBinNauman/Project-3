using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class CameraPointer : MonoBehaviour
{
    private const float _maxDistance = 100;
    private GameObject _gazedAtObject = null;
    public Camera cam;
    public LayerMask is_floor;
    public UnityEngine.AI.NavMeshAgent agent;
    public bool is_moving = false;
    public float speed;


    public void Update()
    {
        if (Google.XR.Cardboard.Api.IsTriggerPressed || Input.GetMouseButtonDown(0))
        {
            Debug.Log("here");
            RaycastHit hit;
            RaycastHit hit_2;
            Ray ray;
            ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(transform.position, transform.forward, out hit, _maxDistance, is_floor))
            {
                if (Physics.Raycast(ray, out hit_2, 500f, is_floor))
                {
                    agent.SetDestination(hit.point);
                    Debug.Log("is this working");
                    

                }
          
            }
            _gazedAtObject?.SendMessage("OnPointerClick");


        }
        speed = agent.velocity.magnitude;
        if (speed > 0)
        {
            is_moving = true;
        }
        if(speed == 0)
        {
            is_moving = false;
        }
    }
}