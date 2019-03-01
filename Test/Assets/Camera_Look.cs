using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera_Look : MonoBehaviour
{
    //// Start is called before the first frame update
    //void Start()
    //{
        
    //}

    // Update is called once per frame
    public Transform playerObject;

    public float distanceFromObject = 6f;
    public float distanceDivider = 3f;
    public float distanceHeight = 2f;

    void FixedUpdate()
    {
        Vector3 lookOnObject = playerObject.position - transform.position;
        lookOnObject = playerObject.position - transform.position;
        transform.forward = lookOnObject.normalized;

        Vector3 playerLastPosition;
        playerLastPosition = playerObject.position - lookOnObject.normalized * distanceFromObject;

        playerLastPosition.y = playerObject.position.y + distanceFromObject / distanceDivider;

        transform.position = playerLastPosition;
    }
}
