using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallHitController : MonoBehaviour
{
    [SerializeField]
    private Rigidbody rb;
    [SerializeField]
    private float forceHit = 100;
    [SerializeField]
    private LineRenderer lr;
    bool impactTrajectory = false;

    private void Update()
    {
        if (impactTrajectory == true)
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit, 100))
            {
                Vector3 hitDirection = transform.position - hit.point;
                Vector3[] linePoints = new Vector3[2];
                linePoints[0] = transform.position;
                linePoints[1] = hitDirection;
                lr.SetPositions(linePoints);
            }
        }
        else
        {
            Vector3[] linePoints = new Vector3[2];
            linePoints[0] = Vector3.one * 10000;
            linePoints[1] = Vector3.one * 10000;
            lr.SetPositions(linePoints);
        }
    }

    private void OnMouseDown()
    {
        impactTrajectory = true;
        Debug.Log("OnMouseDown");
    }

    private void OnMouseUp()
    {
        impactTrajectory = false;
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        if (Physics.Raycast(ray, out hit, 100))
        {
            Vector3 hitDirection = transform.position - hit.point;
            rb.AddForce(hitDirection * forceHit);
            Debug.Log(hit.transform.name);
            Debug.Log("hit");
        }
        Debug.Log("OnMouseUp");
    }
}
