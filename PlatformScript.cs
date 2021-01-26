using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using UnityEngine;
using UnityEngine.UI;

public class PlatformScript : MonoBehaviour
{
    public int vel;
    public Transform point1;
    public Transform point2;
    Vector3 nextPos;

    private void Start()
    {
        nextPos = point1.position;
    }

    // Update is called once per frame
    void FixedUpdate()
    {

        if (transform.position == point1.position)
        {
            nextPos = point2.position;
        }
        if(transform.position == point2.position)
        {
            nextPos = point1.position;
        }

        transform.position = Vector3.MoveTowards(transform.position, nextPos, vel * Time.deltaTime);

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        collision.collider.transform.SetParent(transform);
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        collision.collider.transform.SetParent(null);
    }
    //private void OnDrawGizmos()
    //{
    //    Gizmos.DrawLine(point1.position, point2.position);
    //}
}
