using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public GameObject player;
    private Vector3 offset; 
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
       offset = transform.position - player.transform.position; 
    }

    // LateUpdate is called once per frame, but as the last code
    void LateUpdate()
    {
        transform.position = player.transform.position + offset;
    }
}
