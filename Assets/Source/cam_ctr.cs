using UnityEngine;
using System.Collections;

public class cam_ctr : MonoBehaviour {

	Camera cam;

	// Use this for initialization
	void Start () {
	
	}

	public void set_rot(Vector3 target)
	{
		cam.transform.Rotate (target);
	}

	public void set_pos(Vector3 target)
	{
		cam.transform.position = target;
	}

	public void set_cam(Camera cam)
	{
		this.cam = cam;
	}
	// Update is called once per frame
	void Update () {
	
	}
}
