using UnityEngine;
using System.Collections;

public class GameCamera : MonoBehaviour 
{

    private Camera cam;
    // Use this for initialization

	void Start () 
    {
        cam = GetComponent<Camera>();
        cam.orthographicSize = 6 / cam.aspect;
        cam.transform.position = new Vector3(6, cam.orthographicSize, -10);
	}
	
	// Update is called once per frame
	void Update () 
    {
	
	}
}
