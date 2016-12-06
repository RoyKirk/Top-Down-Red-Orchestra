using UnityEngine;
using System.Collections;

public class CameraFollow : MonoBehaviour
{
    public Transform trackingPos;
	
	// Update is called once per frame
	void LateUpdate ()
    {
        transform.position = trackingPos.position;
	}
}
