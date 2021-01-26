using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform target;
    public float smoothSpeed = 0.5f;
    public Vector3 offset;
    public MyData data;
    Vector3 desiredPosition;

    private void LateUpdate()
    {
        if(data.thisPlayer == data.player1)
        { 
            target = data.thisPlayer.transform;
            desiredPosition = target.position +offset;
        }
        else
        {
            target = data.thisPlayer.transform;
            desiredPosition = target.position +offset;
        }

        Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);
        transform.position = smoothedPosition;
    }

}
