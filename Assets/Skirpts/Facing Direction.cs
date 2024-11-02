using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FacingDirection : MonoBehaviour
{
    public GameObject OtherObject;
    public int distance;

    private void Start()
    {
        transform.position = Vector3.forward;
    }

    private void OnDrawGizmos()
    {
        //Makes a yellow line facing away from the cube
        //shortens the line using the .normalized
        Gizmos.color = Color.yellow;
        Gizmos.DrawLine(Vector3.zero, (OtherObject.transform.position  - 
            transform.position).normalized);


        //Changes the color based off the distance between objects.
        if (Vector3.Distance(transform.position, OtherObject.transform.position)
            > distance)
        {
            Gizmos.color = Color.green;
        }
        else
        {
            Gizmos.color = Color.red;
        }

        //Draws the green/red line.
        Gizmos.DrawLine(Vector3.zero, (transform.position - 
            OtherObject.transform.position));

        //changes the rotation of the lil guy game object.
        Vector3 directionTo = (transform.position - 
            OtherObject.transform.position).normalized;
        OtherObject.transform.forward = directionTo;
    }

}
