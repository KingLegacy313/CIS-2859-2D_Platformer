using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VMovingPlatform : MonoBehaviour
{
    [SerializeField]
    private Vector3 finishPos = Vector3.zero;

    [SerializeField]
    private float speed = 0.5f;

    private Vector3 startPos;
    private float trackPercent = 0f;
    private int direction = 1;

    void Start()
    {
        startPos = transform.position;
    }


    void Update()
    {
        trackPercent += direction * speed * Time.deltaTime;

        
        float y = (finishPos.y - startPos.y) * trackPercent + startPos.y;
        transform.position = new Vector3(startPos.x, y, startPos.z);

        if ((direction == 1 && trackPercent > 0.9f) ||
          (direction == -1 && trackPercent < 0.1f))
        {
            direction *= -1;
        }//end if
    }//end Update
}
