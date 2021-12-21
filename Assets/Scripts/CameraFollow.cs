using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    Transform cameraTransform;
    public GameObject follow;
    // Start is called before the first frame update
    void Start()
    {
        cameraTransform = GetComponent<Transform>();   
    }

    // Update is called once per frame
    void Update()
    {
        cameraTransform.SetPositionAndRotation(new Vector3(follow.transform.position.x, follow.transform.position.y, -10), follow.transform.rotation);
    }
}
