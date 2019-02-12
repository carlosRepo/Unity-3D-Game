using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera : MonoBehaviour
{
    public Transform lookAt;
    public Transform camTransform;
    public Camera cam;

    public float distance =2.0f;
    public float currentX =0.0f;
    public float currentY =2.0f;
    public float sensivityX =4.0f;
    public float sensivityY =1.0f;

    // Start is called before the first frame update
    private void Start()
    {
        camTransform = transform;
        cam=Camera.main;
    }

    // Update is called once per frame
    private void LateUpdate()
    {
        Vector3 dir= new Vector3(0,0,-distance);
        Quaternion rotation = Quaternion.Euler(currentX,currentY,0);
        camTransform.position= lookAt.position + rotation * dir;
    }
}
