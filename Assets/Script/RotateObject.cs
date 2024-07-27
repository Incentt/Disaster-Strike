using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateObject : MonoBehaviour
{
    private Touch touch;
    private Quaternion rotationY;
    private Vector2 TouchPos;
    private float rotatespeed = 0.5f;

    private void Update()
    {
        if (Input.touchCount > 0)
        {
            touch = Input.GetTouch(0);
            if (touch.phase == TouchPhase.Moved)
            {
                rotationY = Quaternion.Euler(0, touch.deltaPosition.x * -rotatespeed, 0f);
                transform.localRotation = rotationY * transform.localRotation;
            }
        }
    }
}
