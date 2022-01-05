using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NextRoom : MonoBehaviour
{
    public GameObject cameratomove;
    public GameObject BackWall;

    public Vector3 movedirection;
    private Vector3 nextRoomPos = new Vector3(0, 0, -10);
    public float cameraMoveSpeed = 1f;

    void OnTriggerEnter2D()
    {
        nextRoomPos += movedirection;
        BackWall.transform.position += movedirection;
        CameraMovement();
    }

    void CameraMovement()
    {
        if (cameratomove.transform.position != nextRoomPos)
        {
            cameratomove.transform.position = Vector3.MoveTowards(cameratomove.transform.position, nextRoomPos, cameraMoveSpeed * Time.deltaTime);
            Invoke("CameraMovement", 0.01f);
        }
    }
}
