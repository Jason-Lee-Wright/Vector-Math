using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FacingDirection : MonoBehaviour
{
    public GameObject OtherObject;

    private void Start()
    {
        transform.position = Vector3.forward;
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.yellow;
        Gizmos.DrawLine(Vector3.zero, (OtherObject.transform.position  - transform.position).normalized);

        Gizmos.color = Color.red;
        Gizmos.DrawLine(Vector3.zero, (transform.position - OtherObject.transform.position).normalized);

        Vector3 directionTo = (transform.position - OtherObject.transform.position);
        OtherObject.transform.forward = directionTo;
    }

}
