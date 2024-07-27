using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TsunamiWave : MonoBehaviour
{
    public float speed = 0.5f; 
    private Renderer rend;
    private Material material;
    private Vector2 offset;

    void Start()
    {
        rend = GetComponent<Renderer>();
        material = rend.material;
        offset = Vector2.zero;
    }

    void Update()
    {
        offset.x -= speed * Time.deltaTime;
        material.SetTextureOffset("_BaseMap", offset);  
    }
}
