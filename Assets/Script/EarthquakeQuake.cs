using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EarthquakeQuake : MonoBehaviour
{
    public float magnitude = 0.005f;
    public float frequency = 0.05f; 

    private Vector3 originalPosition;
    private bool isActive;
    private float shakeTimer;

    void Start()
    {
        originalPosition = transform.localPosition;
    }

    private void OnEnable()
    {
        isActive = true;
    }

    private void OnDisable()
    {
        isActive = false;
        transform.localPosition = originalPosition;
    }

    void Update()
    {
        if (isActive)
        {
            shakeTimer += Time.deltaTime;
            if (shakeTimer >= frequency)
            {
                Vector3 randomPoint = originalPosition + Random.insideUnitSphere * magnitude;
                transform.localPosition = new Vector3(randomPoint.x, originalPosition.y, randomPoint.z);
                shakeTimer = 0.0f;  // Reset the timer
            }
        }
        else
        {
            transform.localPosition = originalPosition;
        }
    }
}
