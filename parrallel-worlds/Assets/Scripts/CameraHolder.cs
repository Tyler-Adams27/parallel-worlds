using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraHolder : MonoBehaviour
{
    public Transform cameraPostiion;
    private void Update()
    {
        transform.position = cameraPostiion.position;
    }
}
