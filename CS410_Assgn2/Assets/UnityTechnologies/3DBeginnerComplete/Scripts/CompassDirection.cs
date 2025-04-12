using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CompassDirection : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    Quaternion from;
    Quaternion to;
    Vector2 up = Vector2.up;
    Vector2 relativeDirection2D;
    Vector3 relativeDirection3D;
    float angle = 0.0f;
    public float speed = 5.0f;
    public Transform lemonPosition;
    public Transform finishPosition;
    Quaternion targetRotation;


    void Start () {
        transform.rotation = Quaternion.Euler(0,0,0);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        relativeDirection3D = finishPosition.position - lemonPosition.position;         // 3D Vector pointing to end
        relativeDirection2D = new Vector2(relativeDirection3D.x, relativeDirection3D.z);// 2D Vector pointing to end
        angle = (Vector2.SignedAngle(up, relativeDirection2D));                         // Get angle between 0-360
        targetRotation = Quaternion.Euler(0,0,angle);                                   // Derive target rotation
        transform.rotation = Quaternion.Lerp(transform.rotation, targetRotation, speed * Time.deltaTime); //Smooth Lerp with target rotation

    }
}
